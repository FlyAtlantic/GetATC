﻿using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Drawing;
using System.Windows.Forms;
using static GetAtc.GetXMLInfos;

namespace GetAtc
{
    public partial class Form1 : Form
    {
        private AppContext Context;
        Telemetry t;
        List<Clients> clients = null;
        public static string Callsign;
        CallsignFrm c = new CallsignFrm();

        public Form1(AppContext context)
        {

            InitializeComponent();
            Context = context;

            DoStuffAsync();

            ManagePilot.FSUIPC_Connect();

            t = Telemetry.GetCurrent();

            txtFreq.Text = t.RadioCom1.ToString("F3").Replace(",", ".");

            txtUfreq.ForeColor = Color.DarkGoldenrod;
            txtUfreq.Text = t.RadioCom1Standby.ToString("F3").Replace(",", ".");

            txtCallsign.ForeColor = Color.DarkRed;          

            timerFrequency.Start();

            if (ManagePilot.FsuiipcOpen)
            {
                txtFsuipc.ForeColor = Color.Green;
                txtFsuipc.Text = "FSUIPC Connected";
            }
            else
            {
                txtFsuipc.ForeColor = Color.Red;
                txtFsuipc.Text = "Waitting for Sim";
            }

            if(txtCallsign.Text == "------")
            {
                Enabled = false;
                c.Show();

            }

            Console.WriteLine("{0}", t.Location);

        }

        public static void ReceiveCallsign(string callsign)
        {
            if(Callsign == null)
            {
                Callsign = callsign;                
                Telemetry.ManualUnicom();
                System.Diagnostics.Process.Start(@"teamspeak://snet.flyatlantic-va.com:8767/nickname=" + Callsign + "?login=anonimous?channel=unicom");
            }

            Callsign = callsign;

        }

        public async void DoStuffAsync()
        {
            timerGetATC.Stop();

            clients = await Context.FaStatusServer.GetAsync<Clients>("clients", false, "{\"clienttype\":\"ATC\"}");

            lstATC.Items.Clear();
            if (clients.Count > 0)
            {
                foreach (var item in clients)
                {
                    GeoCoordinate Location2 = new GeoCoordinate(Convert.ToDouble(item.location[1].Replace(".", ",")), Convert.ToDouble(item.location[0].Replace(".", ",")));
                    string distance = (Convert.ToInt32(t.Location.GetDistanceTo(Location2)) * 0.000539956803).ToString("F0");

                    string[] split = item.callsign.ToString().Split('_');

                    foreach (string word in split)
                    {
                        switch (word)
                        {
                            case "FSS":
                                if (Convert.ToInt32(distance) < 2000)
                                {

                                    lstATC.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                                    lstATC.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                                    lstATC.Items.Add(new ListViewItem(new string[]{
                                    item.callsign.ToString(),
                                    item.frequency.ToString(),
                                    item.realname.ToString(),
                                    distance + " NM"
                                     }));


                                }
                                else
                                {
                                    Console.WriteLine("FSS // Nothing on your Range");
                                }
                                break;

                            case "CTR":
                                if (Convert.ToInt32(distance) < 500)
                                {

                                    lstATC.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                                    lstATC.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                                    lstATC.Items.Add(new ListViewItem(new string[]{
                                    item.callsign.ToString(),
                                    item.frequency.ToString(),
                                    item.realname.ToString(),
                                    distance + " NM"
                                     }));


                                }
                                else
                                {
                                    Console.WriteLine("CTR // Nothing on your Range");
                                }
                                break;

                            case "APP":
                                if (Convert.ToInt32(distance) < 100)
                                {

                                    lstATC.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                                    lstATC.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                                    lstATC.Items.Add(new ListViewItem(new string[]{
                                    item.callsign.ToString(),
                                    item.frequency.ToString(),
                                    item.realname.ToString(),
                                    distance + " NM"
                                     }));


                                }
                                else
                                {
                                    Console.WriteLine("APP // Nothing on your Range");
                                }
                                break;

                            case "DEP":
                                if (Convert.ToInt32(distance) < 100)
                                {

                                    lstATC.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                                    lstATC.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                                    lstATC.Items.Add(new ListViewItem(new string[]{
                                    item.callsign.ToString(),
                                    item.frequency.ToString(),
                                    item.realname.ToString(),
                                    distance + " NM"
                                     }));


                                }
                                else
                                {
                                    Console.WriteLine("DEP // Nothing on your Range");
                                }
                                break;

                            case "TWR":
                                if (Convert.ToInt32(distance) < 30)
                                {

                                    lstATC.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                                    lstATC.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                                    lstATC.Items.Add(new ListViewItem(new string[]{
                                    item.callsign.ToString(),
                                    item.frequency.ToString(),
                                    item.realname.ToString(),
                                    distance + " NM"
                                     }));


                                }
                                else
                                {
                                    Console.WriteLine("TWR // Nothing on your Range");
                                }
                                break;

                            case "GND":
                                if (Convert.ToInt32(distance) < 10)
                                {

                                    lstATC.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                                    lstATC.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                                    lstATC.Items.Add(new ListViewItem(new string[]{
                                    item.callsign.ToString(),
                                    item.frequency.ToString(),
                                    item.realname.ToString(),
                                    distance + " NM"
                                     }));


                                }
                                else
                                {
                                    Console.WriteLine("GND // Nothing on your Range");
                                }
                                break;

                            case "DEL":
                                if (Convert.ToInt32(distance) < 10)
                                {

                                    lstATC.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                                    lstATC.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                                    lstATC.Items.Add(new ListViewItem(new string[]{
                                    item.callsign.ToString(),
                                    item.frequency.ToString(),
                                    item.realname.ToString(),
                                    distance + " NM"
                                     }));


                                }
                                else
                                {
                                    Console.WriteLine("DEL // Nothing on your Range");
                                }
                                break;

                            default:
                                break;
                        }                      
                    }
                }

                
            }         
            timerGetATC.Start();
        }

        private void lstATC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstATC.SelectedItems.Count > 0) {
                txtUfreq.Text = lstATC.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void timerFrequency_Tick(object sender, EventArgs e)
        {
            t = Telemetry.GetCurrent();
            txtFreq.Text = t.RadioCom1.ToString("F3").Replace(",", ".");
            txtUfreq.Text = t.RadioCom1Standby.ToString("F3").Replace(",", ".");
            txtCallsign.Text = Callsign;

            if (c.Visible == false)
            {
                Enabled = true;

                if (txtCallsign.Text != "------")
                {
                    btnModifyCallsign.Visible = true;
                }
            }           
        }
        
        private void txtFreq_TextChanged(object sender, EventArgs e)
        {
            if (clients != null) {
                foreach (var item in clients)
                {
                    if (lstATC.Items.Count > 0)
                    {
                        bool result = (txtFreq.Text == item.frequency.ToString());

                        if (txtCallsign.Text != "")
                        {
                            if (result)
                            {
                                System.Diagnostics.Process.Start(@"teamspeak://snet.flyatlantic-va.com:8767/nickname=" + Callsign + "?login=anonimous?channel=" + item.callsign.ToString() + "");
                            }
                            if (txtFreq.Text == "122.800")
                            {
                                System.Diagnostics.Process.Start(@"teamspeak://snet.flyatlantic-va.com:8767/nickname=" + Callsign + "?login=anonimous?channel=unicom");                                
                            }
                        }
                    }
                }
            }
        }

        private void btnModifyCallsign_Click(object sender, EventArgs e)
        {
            Enabled = false;
            c.Show();
        }

        private void timerGetATC_Tick(object sender, EventArgs e)
        {           
            DoStuffAsync();
        }

        private void btnUnicom_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"teamspeak://snet.flyatlantic-va.com:8767/nickname=" + Callsign + "?login=anonimous?channel=unicom");
            Telemetry.ManualUnicom();
        }
    }
}
