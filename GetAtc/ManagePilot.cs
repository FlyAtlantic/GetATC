using FSUIPC;
using System;
using System.Device.Location;

namespace GetAtc
{
    public class ManagePilot
    {
        public static bool FsuiipcOpen { get; set; }

        public static void FSUIPC_Connect()
        {
            try
            {

                FSUIPCConnection.Open();

                FsuiipcOpen = true;

            }
            catch (Exception crap)
            {
                Console.WriteLine("{0} Exception caught.", crap);

                if (FSUIPCConnection.FlightSimVersionConnected.ToString() == "Any") {
                    FsuiipcOpen = false;

                    FSUIPCConnection.Close();
                    FSUIPC_Connect();
                }
            }
        }

    }

    public class Telemetry
    {
        /// <summary>
        /// RadioCom1
        /// </summary>
        public decimal RadioCom1;

        public decimal RadioCom1Standby;

        public double LAT;

        public double LON;

        public GeoCoordinate Location;

        public static Offset<short> _radio1 = new Offset<short>(0x034E);
        public static Offset<short> _radio1standby = new Offset<short>(0x311A);
        private static Offset<long> _longitude = new Offset<long>(0x0568);
        private static Offset<long> _latitude = new Offset<long>(0x0560);

        public static Telemetry GetCurrent()
        {
            Telemetry result = new Telemetry();

            try
            {
                FSUIPCConnection.Process();
            }
            catch (Exception crap)
            {
                // failed to connect to the sim?
                return null;
            }

            result.RadioCom1 = ((Convert.ToDecimal(_radio1.Value.ToString("X2")) + 10000l) / 100);
            result.RadioCom1Standby = ((Convert.ToDecimal(_radio1standby.Value.ToString("X2")) + 10000l) / 100);
            result.LAT = _latitude.Value * (90.0 / (10001750.0 * 65536.0 * 65536.0));
            result.LON = _longitude.Value * (360.0 / (65536.0 * 65536.0 * 65536.0 * 65536.0));
            result.Location = new GeoCoordinate(result.LAT, result.LON);

            return result;
        }

        public static void ManualUnicom()
        {
            int unicom = 8832;
            _radio1standby.Value = _radio1.Value;
            _radio1.Value = Convert.ToInt16(unicom);
            FSUIPCConnection.Process();
        }
    }  

}
