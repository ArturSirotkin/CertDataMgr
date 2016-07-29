namespace CertDataMgr
{
    partial class AddServerBody
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServerBody));
            this.Module = new System.Windows.Forms.ComboBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Certifier = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Division = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Farm = new System.Windows.Forms.ComboBox();
            this.Shard = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Machine = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Module
            // 
            this.Module.FormattingEnabled = true;
            this.Module.Location = new System.Drawing.Point(74, 17);
            this.Module.MaxLength = 16;
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(140, 21);
            this.Module.TabIndex = 0;
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(74, 179);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(39, 20);
            this.Port.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Port, resources.GetString("Port.ToolTip"));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Module:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Certified by:";
            // 
            // Certifier
            // 
            this.Certifier.FormattingEnabled = true;
            this.Certifier.Location = new System.Drawing.Point(74, 44);
            this.Certifier.MaxLength = 16;
            this.Certifier.Name = "Certifier";
            this.Certifier.Size = new System.Drawing.Size(140, 21);
            this.Certifier.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Certifier, resources.GetString("Certifier.ToolTip"));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Division:";
            // 
            // Division
            // 
            this.Division.FormattingEnabled = true;
            this.Division.Location = new System.Drawing.Point(74, 71);
            this.Division.MaxLength = 16;
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(140, 21);
            this.Division.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Division, "[IMPORTANT]\r\nGlobalManager\r\nDownloadServer\r\nGatewayServer\r\nFarmManager\r\nAgentServ" +
        "er\r\nSR_ShardManager\r\nSR_GameServer\r\nmust be assigned to a Division!");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Farm:";
            // 
            // Farm
            // 
            this.Farm.FormattingEnabled = true;
            this.Farm.Location = new System.Drawing.Point(74, 98);
            this.Farm.MaxLength = 16;
            this.Farm.Name = "Farm";
            this.Farm.Size = new System.Drawing.Size(140, 21);
            this.Farm.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Farm, "[IMPORTANT]\r\nFarmManager\r\nAgentServer\r\nSR_ShardManager\r\nSR_GameServer\r\nmust be as" +
        "signed to a Farm!");
            // 
            // Shard
            // 
            this.Shard.FormattingEnabled = true;
            this.Shard.Location = new System.Drawing.Point(74, 125);
            this.Shard.MaxLength = 16;
            this.Shard.Name = "Shard";
            this.Shard.Size = new System.Drawing.Size(140, 21);
            this.Shard.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Shard, "[IMPORTANT]\r\nAgentServer\r\nSR_ShardManager\r\nSR_GameServer\r\nmust be assigned to a S" +
        "hard!");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Shard:";
            // 
            // Machine
            // 
            this.Machine.FormattingEnabled = true;
            this.Machine.Location = new System.Drawing.Point(74, 152);
            this.Machine.MaxLength = 16;
            this.Machine.Name = "Machine";
            this.Machine.Size = new System.Drawing.Size(140, 21);
            this.Machine.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Machine, "[Machines]\r\nCertification Module must be assigned to \"Certification\" Machine\r\nAnd" +
        " the other Modules must be assigned to different than \"Certification\" Machine");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Machine:";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "[Default]";
            // 
            // AddServerBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Machine);
            this.Controls.Add(this.Shard);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Farm);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Certifier);
            this.Controls.Add(this.Module);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddServerBody";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new Server Body";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Module;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Certifier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Division;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Farm;
        private System.Windows.Forms.ComboBox Shard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Machine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}