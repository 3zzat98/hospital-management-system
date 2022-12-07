namespace izzet_mamo_200509601
{
    partial class adddoktor
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
            this.labelname = new System.Windows.Forms.Label();
            this.labelphone = new System.Windows.Forms.Label();
            this.labelsection = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxphone = new System.Windows.Forms.TextBox();
            this.textBoxaddress = new System.Windows.Forms.TextBox();
            this.labeladdres = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(73, 89);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(66, 20);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "name ;";
            this.labelname.Click += new System.EventHandler(this.labelname_Click);
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelphone.Location = new System.Drawing.Point(69, 158);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(71, 20);
            this.labelphone.TabIndex = 1;
            this.labelphone.Text = "phone :";
            this.labelphone.Click += new System.EventHandler(this.labelphone_Click);
            // 
            // labelsection
            // 
            this.labelsection.AutoSize = true;
            this.labelsection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsection.Location = new System.Drawing.Point(69, 225);
            this.labelsection.Name = "labelsection";
            this.labelsection.Size = new System.Drawing.Size(82, 20);
            this.labelsection.TabIndex = 2;
            this.labelsection.Text = "section :";
            this.labelsection.Click += new System.EventHandler(this.labelsection_Click);
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(172, 89);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(282, 22);
            this.textBoxname.TabIndex = 3;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBoxname_TextChanged);
            // 
            // textBoxphone
            // 
            this.textBoxphone.Location = new System.Drawing.Point(172, 158);
            this.textBoxphone.Name = "textBoxphone";
            this.textBoxphone.Size = new System.Drawing.Size(282, 22);
            this.textBoxphone.TabIndex = 4;
            this.textBoxphone.TextChanged += new System.EventHandler(this.textBoxphone_TextChanged);
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.Location = new System.Drawing.Point(172, 289);
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.Size = new System.Drawing.Size(282, 22);
            this.textBoxaddress.TabIndex = 6;
            this.textBoxaddress.TextChanged += new System.EventHandler(this.textBoxaddress_TextChanged);
            // 
            // labeladdres
            // 
            this.labeladdres.AutoSize = true;
            this.labeladdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladdres.Location = new System.Drawing.Point(69, 292);
            this.labeladdres.Name = "labeladdres";
            this.labeladdres.Size = new System.Drawing.Size(88, 20);
            this.labeladdres.TabIndex = 5;
            this.labeladdres.Text = "address :";
            this.labeladdres.Click += new System.EventHandler(this.labeladdres_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Heart",
            "Bonse",
            "Eyee",
            "Fmale"});
            this.comboBox1.Location = new System.Drawing.Point(172, 222);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(282, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonsave
            // 
            this.buttonsave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonsave.Location = new System.Drawing.Point(172, 367);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(106, 49);
            this.buttonsave.TabIndex = 8;
            this.buttonsave.Text = "save";
            this.buttonsave.UseVisualStyleBackColor = false;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // adddoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 563);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxaddress);
            this.Controls.Add(this.labeladdres);
            this.Controls.Add(this.textBoxphone);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.labelsection);
            this.Controls.Add(this.labelphone);
            this.Controls.Add(this.labelname);
            this.Name = "adddoktor";
            this.Text = "adddoktor";
            this.Load += new System.EventHandler(this.adddoktor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.Label labelsection;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxphone;
        private System.Windows.Forms.TextBox textBoxaddress;
        private System.Windows.Forms.Label labeladdres;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonsave;
    }
}