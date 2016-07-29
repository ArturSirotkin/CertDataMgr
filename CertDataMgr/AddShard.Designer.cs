namespace CertDataMgr
{
    partial class AddShard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddShard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Shard = new System.Windows.Forms.TextBox();
            this.Farm = new System.Windows.Forms.ComboBox();
            this.StartupShardMgr = new System.Windows.Forms.ComboBox();
            this.ShardDBLogConfig = new System.Windows.Forms.TextBox();
            this.ShardDBConfig = new System.Windows.Forms.TextBox();
            this.MaxUser = new System.Windows.Forms.TextBox();
            this.Content = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shard Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Farm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Content:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max User Capacity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Shard DB Info:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Shard Log Info:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Startup Server:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Shard
            // 
            this.Shard.Location = new System.Drawing.Point(117, 9);
            this.Shard.Name = "Shard";
            this.Shard.Size = new System.Drawing.Size(122, 20);
            this.Shard.TabIndex = 8;
            // 
            // Farm
            // 
            this.Farm.FormattingEnabled = true;
            this.Farm.Location = new System.Drawing.Point(117, 38);
            this.Farm.Name = "Farm";
            this.Farm.Size = new System.Drawing.Size(196, 21);
            this.Farm.TabIndex = 9;
            // 
            // StartupShardMgr
            // 
            this.StartupShardMgr.FormattingEnabled = true;
            this.StartupShardMgr.Location = new System.Drawing.Point(117, 190);
            this.StartupShardMgr.Name = "StartupShardMgr";
            this.StartupShardMgr.Size = new System.Drawing.Size(43, 21);
            this.StartupShardMgr.TabIndex = 10;
            // 
            // ShardDBLogConfig
            // 
            this.ShardDBLogConfig.Location = new System.Drawing.Point(117, 164);
            this.ShardDBLogConfig.Name = "ShardDBLogConfig";
            this.ShardDBLogConfig.Size = new System.Drawing.Size(557, 20);
            this.ShardDBLogConfig.TabIndex = 11;
            this.ShardDBLogConfig.Text = "DRIVER={SQL Server};SERVER=;DSN=;UID=;PWD=;DATABASE=";
            // 
            // ShardDBConfig
            // 
            this.ShardDBConfig.Location = new System.Drawing.Point(117, 138);
            this.ShardDBConfig.Name = "ShardDBConfig";
            this.ShardDBConfig.Size = new System.Drawing.Size(557, 20);
            this.ShardDBConfig.TabIndex = 12;
            this.ShardDBConfig.Text = "DRIVER={SQL Server};SERVER=;DSN=;UID=;PWD=;DATABASE=";
            // 
            // MaxUser
            // 
            this.MaxUser.Location = new System.Drawing.Point(117, 104);
            this.MaxUser.Name = "MaxUser";
            this.MaxUser.Size = new System.Drawing.Size(43, 20);
            this.MaxUser.TabIndex = 13;
            // 
            // Content
            // 
            this.Content.FormattingEnabled = true;
            this.Content.Location = new System.Drawing.Point(117, 64);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(196, 21);
            this.Content.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "- SR_ShardManager";
            // 
            // AddShard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 228);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.MaxUser);
            this.Controls.Add(this.ShardDBConfig);
            this.Controls.Add(this.ShardDBLogConfig);
            this.Controls.Add(this.StartupShardMgr);
            this.Controls.Add(this.Farm);
            this.Controls.Add(this.Shard);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddShard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Shard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Shard;
        private System.Windows.Forms.ComboBox Farm;
        private System.Windows.Forms.ComboBox StartupShardMgr;
        private System.Windows.Forms.TextBox ShardDBLogConfig;
        private System.Windows.Forms.TextBox ShardDBConfig;
        private System.Windows.Forms.TextBox MaxUser;
        private System.Windows.Forms.ComboBox Content;
        private System.Windows.Forms.Label label8;
    }
}