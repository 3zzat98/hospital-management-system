namespace izzet_mamo_200509601
{
    partial class home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doktorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDoktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDoktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProccesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProccesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorsToolStripMenuItem,
            this.patientsToolStripMenuItem,
            this.proccessToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doktorsToolStripMenuItem
            // 
            this.doktorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDoktorToolStripMenuItem,
            this.manageDoktorToolStripMenuItem});
            this.doktorsToolStripMenuItem.Name = "doktorsToolStripMenuItem";
            this.doktorsToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.doktorsToolStripMenuItem.Text = "doktors";
            this.doktorsToolStripMenuItem.Click += new System.EventHandler(this.doktorsToolStripMenuItem_Click);
            // 
            // addNewDoktorToolStripMenuItem
            // 
            this.addNewDoktorToolStripMenuItem.Name = "addNewDoktorToolStripMenuItem";
            this.addNewDoktorToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.addNewDoktorToolStripMenuItem.Text = "add new doktor";
            this.addNewDoktorToolStripMenuItem.Click += new System.EventHandler(this.addNewDoktorToolStripMenuItem_Click);
            // 
            // manageDoktorToolStripMenuItem
            // 
            this.manageDoktorToolStripMenuItem.Name = "manageDoktorToolStripMenuItem";
            this.manageDoktorToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.manageDoktorToolStripMenuItem.Text = "manage doktor";
            this.manageDoktorToolStripMenuItem.Click += new System.EventHandler(this.manageDoktorToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managePatientToolStripMenuItem});
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.patientsToolStripMenuItem.Text = "patients";
            this.patientsToolStripMenuItem.Click += new System.EventHandler(this.patientsToolStripMenuItem_Click);
            // 
            // managePatientToolStripMenuItem
            // 
            this.managePatientToolStripMenuItem.Name = "managePatientToolStripMenuItem";
            this.managePatientToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.managePatientToolStripMenuItem.Text = "manage patient";
            // 
            // proccessToolStripMenuItem
            // 
            this.proccessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProccesToolStripMenuItem,
            this.manageProccesToolStripMenuItem});
            this.proccessToolStripMenuItem.Name = "proccessToolStripMenuItem";
            this.proccessToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.proccessToolStripMenuItem.Text = "proccess";
            // 
            // addProccesToolStripMenuItem
            // 
            this.addProccesToolStripMenuItem.Name = "addProccesToolStripMenuItem";
            this.addProccesToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.addProccesToolStripMenuItem.Text = "add procces";
            // 
            // manageProccesToolStripMenuItem
            // 
            this.manageProccesToolStripMenuItem.Name = "manageProccesToolStripMenuItem";
            this.manageProccesToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.manageProccesToolStripMenuItem.Text = "manage procces";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 26);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(293, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATABASE OF HOSPITAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "programmed by  izzet mamo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doktorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDoktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDoktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProccesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProccesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}