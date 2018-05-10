using Eve;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GetAtc.GetXMLInfos;

namespace GetAtc
{
    public partial class VerifyConnection : Form
    {
        public readonly EveClient FaStatusServer = new EveClient("http://139.99.42.165:5000");

        private bool LoggedIn;

        public string Callsign
        { get; set; }

        List<Clients> clients = null;
        
        public VerifyConnection()
        {
            InitializeComponent();

            LoggedIn = false;

            if (txtCID.Text.Length == 6)
            {
                lblValid.ForeColor = Color.Green;
                lblValid.Text = "Valid CID";

                lblInfo.ForeColor = Color.DarkBlue;
                lblInfo.Text = "Press connect button";

                btnConnect.Enabled = true;
            }
            else
            {
                lblValid.ForeColor = Color.Red;
                lblValid.Text = "Invalid CID";

                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "Waitting for valid CID.";

                btnConnect.Enabled = false;
            }
        }

        private void txtCID_TextChanged(object sender, EventArgs e)
        {
            if (txtCID.Text.Length == 6)
            {
                lblValid.ForeColor = Color.Green;
                lblValid.Text = "Valid CID";

                lblInfo.ForeColor = Color.DarkBlue;
                lblInfo.Text = "Press connect button";

                btnConnect.Enabled = true;
            }
            else
            {
                lblValid.ForeColor = Color.Red;
                lblValid.Text = "Invalid CID";

                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "Waitting for valid CID.";

                btnConnect.Enabled = false;
            }
        }

        public async void DoStuffAsync()
        {
            txtCID.Enabled = false;

            btnConnect.Enabled = false;

            clients = await FaStatusServer.GetAsync<Clients>("clients", false, "{\"clienttype\":\"PILOT\"}");

            if (clients.Count > 0)
            {
                foreach (var item in clients)
                {
                    if (item.CID.ToString() == txtCID.Text)
                    {
                        LoggedIn = true;

                        Callsign = item.callsign;
                    }
                    else
                    {
                        LoggedIn = false;
                    }
                }
            }

            if (LoggedIn)
            {
                AppContext f = new AppContext();

                TryConnect_Tick.Stop();

                lblInfo.ForeColor = Color.Green;
                lblInfo.Text = "You are connected to the network.";

                Form1.ReceiveCallsign(Callsign);

                f.form1.Show();

                Hide();
            }
            else
            {
                txtCID.Enabled = true;

                if (txtCID.Text.Length == 6)
                {
                    lblValid.ForeColor = Color.Green;
                    lblValid.Text = "Valid CID";

                    lblInfo.ForeColor = Color.Red;
                    lblInfo.Text = "Your CID is not connected to the network.";

                    btnConnect.Enabled = true;;
                }
                else
                {
                    lblInfo.ForeColor = Color.Red;
                    lblInfo.Text = "Your CID is not connected to the network.";

                    btnConnect.Enabled = false;
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            lblInfo.ForeColor = Color.Goldenrod;
            lblInfo.Text = "Trying to connect...";

            DoStuffAsync();
        }
    }
}
