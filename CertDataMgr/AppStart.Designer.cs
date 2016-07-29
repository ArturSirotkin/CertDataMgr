namespace CertDataMgr
{
    partial class AppStart
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppStart));
            this.addServerBodyBtn = new System.Windows.Forms.Button();
            this.addServerMachineBtn = new System.Windows.Forms.Button();
            this.addDivisionBtn = new System.Windows.Forms.Button();
            this.addFarmBtn = new System.Windows.Forms.Button();
            this.addShardBtn = new System.Windows.Forms.Button();
            this.assignFarmContentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addServerBodyBtn
            // 
            this.addServerBodyBtn.Location = new System.Drawing.Point(13, 252);
            this.addServerBodyBtn.Name = "addServerBodyBtn";
            this.addServerBodyBtn.Size = new System.Drawing.Size(262, 39);
            this.addServerBodyBtn.TabIndex = 0;
            this.addServerBodyBtn.Text = "Add Server Body";
            this.addServerBodyBtn.UseVisualStyleBackColor = true;
            this.addServerBodyBtn.Click += new System.EventHandler(this.addServerBodyBtn_Click);
            // 
            // addServerMachineBtn
            // 
            this.addServerMachineBtn.Location = new System.Drawing.Point(13, 70);
            this.addServerMachineBtn.Name = "addServerMachineBtn";
            this.addServerMachineBtn.Size = new System.Drawing.Size(262, 39);
            this.addServerMachineBtn.TabIndex = 1;
            this.addServerMachineBtn.Text = "Add Server Machine";
            this.addServerMachineBtn.UseVisualStyleBackColor = true;
            this.addServerMachineBtn.Click += new System.EventHandler(this.addServerMachineBtn_Click);
            // 
            // addDivisionBtn
            // 
            this.addDivisionBtn.Location = new System.Drawing.Point(13, 12);
            this.addDivisionBtn.Name = "addDivisionBtn";
            this.addDivisionBtn.Size = new System.Drawing.Size(262, 39);
            this.addDivisionBtn.TabIndex = 2;
            this.addDivisionBtn.Text = "Add Division";
            this.addDivisionBtn.UseVisualStyleBackColor = true;
            this.addDivisionBtn.Click += new System.EventHandler(this.addDivisionBtn_Click);
            // 
            // addFarmBtn
            // 
            this.addFarmBtn.Location = new System.Drawing.Point(13, 129);
            this.addFarmBtn.Name = "addFarmBtn";
            this.addFarmBtn.Size = new System.Drawing.Size(262, 39);
            this.addFarmBtn.TabIndex = 3;
            this.addFarmBtn.Text = "Add Farm";
            this.addFarmBtn.UseVisualStyleBackColor = true;
            this.addFarmBtn.Click += new System.EventHandler(this.addFarmBtn_Click);
            // 
            // addShardBtn
            // 
            this.addShardBtn.Location = new System.Drawing.Point(13, 314);
            this.addShardBtn.Name = "addShardBtn";
            this.addShardBtn.Size = new System.Drawing.Size(262, 39);
            this.addShardBtn.TabIndex = 4;
            this.addShardBtn.Text = "Add Shard";
            this.addShardBtn.UseVisualStyleBackColor = true;
            this.addShardBtn.Click += new System.EventHandler(this.addShardBtn_Click);
            // 
            // assignFarmContentBtn
            // 
            this.assignFarmContentBtn.Location = new System.Drawing.Point(13, 190);
            this.assignFarmContentBtn.Name = "assignFarmContentBtn";
            this.assignFarmContentBtn.Size = new System.Drawing.Size(262, 39);
            this.assignFarmContentBtn.TabIndex = 5;
            this.assignFarmContentBtn.Text = "Assign Content to Farm";
            this.assignFarmContentBtn.UseVisualStyleBackColor = true;
            this.assignFarmContentBtn.Click += new System.EventHandler(this.assignFarmContentBtn_Click);
            // 
            // AppStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 386);
            this.Controls.Add(this.assignFarmContentBtn);
            this.Controls.Add(this.addShardBtn);
            this.Controls.Add(this.addFarmBtn);
            this.Controls.Add(this.addDivisionBtn);
            this.Controls.Add(this.addServerMachineBtn);
            this.Controls.Add(this.addServerBodyBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AppStart";
            this.Text = "Certification Data Manager [ALPHA]";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addServerBodyBtn;
        private System.Windows.Forms.Button addServerMachineBtn;
        private System.Windows.Forms.Button addDivisionBtn;
        private System.Windows.Forms.Button addFarmBtn;
        private System.Windows.Forms.Button addShardBtn;
        private System.Windows.Forms.Button assignFarmContentBtn;
    }
}

