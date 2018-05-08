using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetAtc
{
    public partial class CallsignFrm : Form
    {
       public string Callsign
       { get; set; }

        public CallsignFrm()
        {
            InitializeComponent();

            this.BringToFront();

            this.AcceptButton = btnSendCalsign;
        }

        private void btnSendCalsign_Click(object sender, EventArgs e)
        {
            if (txtCallsign.Text != "")
            {
                Form1.ReceiveCallsign(txtCallsign.Text);
                Hide();
            }
            else
                MessageBox.Show("Please insert your callsign!", "Stand-by!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
