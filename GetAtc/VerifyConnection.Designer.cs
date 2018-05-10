namespace GetAtc
{
    partial class VerifyConnection
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
            this.txtCID = new System.Windows.Forms.TextBox();
            this.lblCID = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblValid = new System.Windows.Forms.Label();
            this.TryConnect_Tick = new System.Windows.Forms.Timer(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(53, 12);
            this.txtCID.MaxLength = 6;
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(100, 20);
            this.txtCID.TabIndex = 0;
            this.txtCID.TextChanged += new System.EventHandler(this.txtCID_TextChanged);
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCID.Location = new System.Drawing.Point(11, 15);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(36, 13);
            this.lblCID.TabIndex = 1;
            this.lblCID.Text = "CID :";
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(229, 15);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(286, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "CID :";
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValid.Location = new System.Drawing.Point(159, 15);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(36, 13);
            this.lblValid.TabIndex = 3;
            this.lblValid.Text = "CID :";
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(521, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // VerifyConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 38);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblCID);
            this.Controls.Add(this.txtCID);
            this.Name = "VerifyConnection";
            this.Text = "VerifyConnection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.Timer TryConnect_Tick;
        private System.Windows.Forms.Button btnConnect;
    }
}