namespace CertDataMgr
{
    partial class AddServerMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServerMachine));
            this.label1 = new System.Windows.Forms.Label();
            this.MachineName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PublicIP = new System.Windows.Forms.ComboBox();
            this.PrivateIP = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Division = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Machine Name:";
            // 
            // MachineName
            // 
            this.MachineName.Location = new System.Drawing.Point(92, 37);
            this.MachineName.MaxLength = 32;
            this.MachineName.Name = "MachineName";
            this.MachineName.Size = new System.Drawing.Size(165, 20);
            this.MachineName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Public IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Private IP:";
            // 
            // PublicIP
            // 
            this.PublicIP.FormattingEnabled = true;
            this.PublicIP.Location = new System.Drawing.Point(92, 63);
            this.PublicIP.MaxLength = 16;
            this.PublicIP.Name = "PublicIP";
            this.PublicIP.Size = new System.Drawing.Size(165, 21);
            this.PublicIP.TabIndex = 2;
            // 
            // PrivateIP
            // 
            this.PrivateIP.FormattingEnabled = true;
            this.PrivateIP.Location = new System.Drawing.Point(92, 90);
            this.PrivateIP.MaxLength = 16;
            this.PrivateIP.Name = "PrivateIP";
            this.PrivateIP.Size = new System.Drawing.Size(165, 21);
            this.PrivateIP.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Division:";
            // 
            // Division
            // 
            this.Division.FormattingEnabled = true;
            this.Division.Location = new System.Drawing.Point(92, 10);
            this.Division.MaxLength = 32;
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(165, 21);
            this.Division.TabIndex = 2;
            // 
            // AddServerMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 163);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PrivateIP);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.PublicIP);
            this.Controls.Add(this.MachineName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddServerMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new Server Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MachineName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PublicIP;
        private System.Windows.Forms.ComboBox PrivateIP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Division;
    }
}