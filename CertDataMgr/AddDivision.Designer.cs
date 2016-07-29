namespace CertDataMgr
{
    partial class AddDivision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDivision));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DivisionName = new System.Windows.Forms.TextBox();
            this.DivisionDBConfig = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Division Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account DB Info:";
            // 
            // DivisionName
            // 
            this.DivisionName.Location = new System.Drawing.Point(108, 13);
            this.DivisionName.MaxLength = 32;
            this.DivisionName.Name = "DivisionName";
            this.DivisionName.Size = new System.Drawing.Size(539, 20);
            this.DivisionName.TabIndex = 2;
            // 
            // DivisionDBConfig
            // 
            this.DivisionDBConfig.Location = new System.Drawing.Point(108, 51);
            this.DivisionDBConfig.MaxLength = 256;
            this.DivisionDBConfig.Name = "DivisionDBConfig";
            this.DivisionDBConfig.Size = new System.Drawing.Size(539, 20);
            this.DivisionDBConfig.TabIndex = 3;
            this.DivisionDBConfig.Text = "DRIVER={SQL Server};SERVER=;DSN=;UID=;PWD=;DATABASE=";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 127);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DivisionDBConfig);
            this.Controls.Add(this.DivisionName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddDivision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new Division";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DivisionName;
        private System.Windows.Forms.TextBox DivisionDBConfig;
        private System.Windows.Forms.Button button1;
    }
}