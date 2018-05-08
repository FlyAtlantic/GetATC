namespace GetAtc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstATC = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerFrequency = new System.Windows.Forms.Timer(this.components);
            this.txtUfreq = new System.Windows.Forms.Label();
            this.lblUcom1 = new System.Windows.Forms.Label();
            this.txtFsuipc = new System.Windows.Forms.Label();
            this.lblFSUIPC = new System.Windows.Forms.Label();
            this.txtFreq = new System.Windows.Forms.Label();
            this.lblFreq = new System.Windows.Forms.Label();
            this.txtCallsign = new System.Windows.Forms.Label();
            this.lblCallsign = new System.Windows.Forms.Label();
            this.btnModifyCallsign = new System.Windows.Forms.Button();
            this.timerGetATC = new System.Windows.Forms.Timer(this.components);
            this.btnUnicom = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstATC
            // 
            this.lstATC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstATC.FullRowSelect = true;
            this.lstATC.Location = new System.Drawing.Point(12, 12);
            this.lstATC.MultiSelect = false;
            this.lstATC.Name = "lstATC";
            this.lstATC.Size = new System.Drawing.Size(273, 270);
            this.lstATC.TabIndex = 3;
            this.lstATC.UseCompatibleStateImageBehavior = false;
            this.lstATC.View = System.Windows.Forms.View.Details;
            this.lstATC.SelectedIndexChanged += new System.EventHandler(this.lstATC_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Callsign";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Freq";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            // 
            // timerFrequency
            // 
            this.timerFrequency.Tick += new System.EventHandler(this.timerFrequency_Tick);
            // 
            // txtUfreq
            // 
            this.txtUfreq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUfreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUfreq.ForeColor = System.Drawing.Color.Blue;
            this.txtUfreq.Location = new System.Drawing.Point(291, 135);
            this.txtUfreq.Name = "txtUfreq";
            this.txtUfreq.Size = new System.Drawing.Size(144, 23);
            this.txtUfreq.TabIndex = 24;
            this.txtUfreq.Text = "------";
            this.txtUfreq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUcom1
            // 
            this.lblUcom1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUcom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUcom1.Location = new System.Drawing.Point(287, 112);
            this.lblUcom1.Name = "lblUcom1";
            this.lblUcom1.Size = new System.Drawing.Size(152, 23);
            this.lblUcom1.TabIndex = 23;
            this.lblUcom1.Text = "Un-Active Com1";
            this.lblUcom1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFsuipc
            // 
            this.txtFsuipc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFsuipc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFsuipc.ForeColor = System.Drawing.Color.Blue;
            this.txtFsuipc.Location = new System.Drawing.Point(291, 35);
            this.txtFsuipc.Name = "txtFsuipc";
            this.txtFsuipc.Size = new System.Drawing.Size(144, 23);
            this.txtFsuipc.TabIndex = 22;
            this.txtFsuipc.Text = "------";
            this.txtFsuipc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFSUIPC
            // 
            this.lblFSUIPC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFSUIPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFSUIPC.Location = new System.Drawing.Point(287, 12);
            this.lblFSUIPC.Name = "lblFSUIPC";
            this.lblFSUIPC.Size = new System.Drawing.Size(152, 23);
            this.lblFSUIPC.TabIndex = 21;
            this.lblFSUIPC.Text = "FSUIPC";
            this.lblFSUIPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFreq
            // 
            this.txtFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreq.ForeColor = System.Drawing.Color.Blue;
            this.txtFreq.Location = new System.Drawing.Point(291, 89);
            this.txtFreq.Name = "txtFreq";
            this.txtFreq.Size = new System.Drawing.Size(144, 23);
            this.txtFreq.TabIndex = 20;
            this.txtFreq.Text = "------";
            this.txtFreq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtFreq.TextChanged += new System.EventHandler(this.txtFreq_TextChanged);
            // 
            // lblFreq
            // 
            this.lblFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreq.Location = new System.Drawing.Point(287, 66);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(152, 23);
            this.lblFreq.TabIndex = 19;
            this.lblFreq.Text = "Your Frequency";
            this.lblFreq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCallsign
            // 
            this.txtCallsign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCallsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCallsign.ForeColor = System.Drawing.Color.Blue;
            this.txtCallsign.Location = new System.Drawing.Point(291, 190);
            this.txtCallsign.Name = "txtCallsign";
            this.txtCallsign.Size = new System.Drawing.Size(144, 23);
            this.txtCallsign.TabIndex = 26;
            this.txtCallsign.Text = "------";
            this.txtCallsign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCallsign
            // 
            this.lblCallsign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCallsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallsign.Location = new System.Drawing.Point(287, 167);
            this.lblCallsign.Name = "lblCallsign";
            this.lblCallsign.Size = new System.Drawing.Size(152, 23);
            this.lblCallsign.TabIndex = 25;
            this.lblCallsign.Text = "Callsign";
            this.lblCallsign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModifyCallsign
            // 
            this.btnModifyCallsign.Location = new System.Drawing.Point(327, 216);
            this.btnModifyCallsign.Name = "btnModifyCallsign";
            this.btnModifyCallsign.Size = new System.Drawing.Size(75, 23);
            this.btnModifyCallsign.TabIndex = 27;
            this.btnModifyCallsign.Text = "Edit Callsign";
            this.btnModifyCallsign.UseVisualStyleBackColor = true;
            this.btnModifyCallsign.Visible = false;
            this.btnModifyCallsign.Click += new System.EventHandler(this.btnModifyCallsign_Click);
            // 
            // timerGetATC
            // 
            this.timerGetATC.Interval = 60000;
            this.timerGetATC.Tick += new System.EventHandler(this.timerGetATC_Tick);
            // 
            // btnUnicom
            // 
            this.btnUnicom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnicom.ForeColor = System.Drawing.Color.DarkRed;
            this.btnUnicom.Location = new System.Drawing.Point(309, 252);
            this.btnUnicom.Name = "btnUnicom";
            this.btnUnicom.Size = new System.Drawing.Size(108, 23);
            this.btnUnicom.TabIndex = 28;
            this.btnUnicom.Text = "Monitor Unicom";
            this.btnUnicom.UseVisualStyleBackColor = true;
            this.btnUnicom.Click += new System.EventHandler(this.btnUnicom_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Location";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 287);
            this.Controls.Add(this.btnUnicom);
            this.Controls.Add(this.btnModifyCallsign);
            this.Controls.Add(this.txtCallsign);
            this.Controls.Add(this.lblCallsign);
            this.Controls.Add(this.txtUfreq);
            this.Controls.Add(this.lblUcom1);
            this.Controls.Add(this.txtFsuipc);
            this.Controls.Add(this.lblFSUIPC);
            this.Controls.Add(this.txtFreq);
            this.Controls.Add(this.lblFreq);
            this.Controls.Add(this.lstATC);
            this.Name = "Form1";
            this.Text = "FlyAtlantic ATC_Client V1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lstATC;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Timer timerFrequency;
        private System.Windows.Forms.Label txtUfreq;
        private System.Windows.Forms.Label lblUcom1;
        private System.Windows.Forms.Label txtFsuipc;
        private System.Windows.Forms.Label lblFSUIPC;
        private System.Windows.Forms.Label txtFreq;
        private System.Windows.Forms.Label lblFreq;
        private System.Windows.Forms.Label lblCallsign;
        public System.Windows.Forms.Label txtCallsign;
        private System.Windows.Forms.Button btnModifyCallsign;
        private System.Windows.Forms.Timer timerGetATC;
        private System.Windows.Forms.Button btnUnicom;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}