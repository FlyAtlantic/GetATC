namespace GetAtc
{
    partial class CallsignFrm
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
            this.lblCallsign = new System.Windows.Forms.Label();
            this.txtCallsign = new System.Windows.Forms.TextBox();
            this.btnSendCalsign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCallsign
            // 
            this.lblCallsign.AutoSize = true;
            this.lblCallsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallsign.Location = new System.Drawing.Point(12, 9);
            this.lblCallsign.Name = "lblCallsign";
            this.lblCallsign.Size = new System.Drawing.Size(136, 15);
            this.lblCallsign.TabIndex = 0;
            this.lblCallsign.Text = "Insert Your Callsign:";
            // 
            // txtCallsign
            // 
            this.txtCallsign.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCallsign.Location = new System.Drawing.Point(15, 27);
            this.txtCallsign.MaxLength = 7;
            this.txtCallsign.Name = "txtCallsign";
            this.txtCallsign.Size = new System.Drawing.Size(133, 20);
            this.txtCallsign.TabIndex = 1;
            // 
            // btnSendCalsign
            // 
            this.btnSendCalsign.Location = new System.Drawing.Point(158, 21);
            this.btnSendCalsign.Name = "btnSendCalsign";
            this.btnSendCalsign.Size = new System.Drawing.Size(75, 23);
            this.btnSendCalsign.TabIndex = 2;
            this.btnSendCalsign.Text = "Send";
            this.btnSendCalsign.UseVisualStyleBackColor = true;
            this.btnSendCalsign.Click += new System.EventHandler(this.btnSendCalsign_Click);
            // 
            // CallsignFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 56);
            this.Controls.Add(this.btnSendCalsign);
            this.Controls.Add(this.txtCallsign);
            this.Controls.Add(this.lblCallsign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CallsignFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Callsign";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCallsign;
        private System.Windows.Forms.TextBox txtCallsign;
        private System.Windows.Forms.Button btnSendCalsign;
    }
}