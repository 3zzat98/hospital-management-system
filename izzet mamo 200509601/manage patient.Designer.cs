namespace izzet_mamo_200509601
{
    partial class manage_patient
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
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttonclose = new System.Windows.Forms.Button();
            this.labelname = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxstate = new System.Windows.Forms.TextBox();
            this.textBoxage = new System.Windows.Forms.TextBox();
            this.textBoxaddress = new System.Windows.Forms.TextBox();
            this.textBoxphone = new System.Windows.Forms.TextBox();
            this.labelphone = new System.Windows.Forms.Label();
            this.labeladdress = new System.Windows.Forms.Label();
            this.labelage = new System.Windows.Forms.Label();
            this.labelstate = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelsection = new System.Windows.Forms.Label();
            this.buttonaddnew = new System.Windows.Forms.Button();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttondelete
            // 
            this.buttondelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.ForeColor = System.Drawing.Color.Navy;
            this.buttondelete.Location = new System.Drawing.Point(432, 589);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(120, 50);
            this.buttondelete.TabIndex = 1;
            this.buttondelete.Text = "delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdate.ForeColor = System.Drawing.Color.Navy;
            this.buttonupdate.Location = new System.Drawing.Point(714, 589);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(120, 50);
            this.buttonupdate.TabIndex = 2;
            this.buttonupdate.Text = "update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclose.ForeColor = System.Drawing.Color.Red;
            this.buttonclose.Location = new System.Drawing.Point(979, 589);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(120, 50);
            this.buttonclose.TabIndex = 3;
            this.buttonclose.Text = "close";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(19, 105);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(66, 20);
            this.labelname.TabIndex = 4;
            this.labelname.Text = "name :";
            this.labelname.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(112, 103);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(180, 22);
            this.textBoxname.TabIndex = 5;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxstate
            // 
            this.textBoxstate.Location = new System.Drawing.Point(112, 331);
            this.textBoxstate.Multiline = true;
            this.textBoxstate.Name = "textBoxstate";
            this.textBoxstate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxstate.Size = new System.Drawing.Size(180, 124);
            this.textBoxstate.TabIndex = 6;
            // 
            // textBoxage
            // 
            this.textBoxage.Location = new System.Drawing.Point(112, 267);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.Size = new System.Drawing.Size(180, 22);
            this.textBoxage.TabIndex = 7;
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.Location = new System.Drawing.Point(112, 205);
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.Size = new System.Drawing.Size(180, 22);
            this.textBoxaddress.TabIndex = 8;
            // 
            // textBoxphone
            // 
            this.textBoxphone.Location = new System.Drawing.Point(112, 152);
            this.textBoxphone.Name = "textBoxphone";
            this.textBoxphone.Size = new System.Drawing.Size(180, 22);
            this.textBoxphone.TabIndex = 9;
            this.textBoxphone.TextChanged += new System.EventHandler(this.textBoxphone_TextChanged);
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelphone.Location = new System.Drawing.Point(14, 152);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(71, 20);
            this.labelphone.TabIndex = 10;
            this.labelphone.Text = "phone :";
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladdress.Location = new System.Drawing.Point(14, 207);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(82, 20);
            this.labeladdress.TabIndex = 11;
            this.labeladdress.Text = "address:";
            // 
            // labelage
            // 
            this.labelage.AutoSize = true;
            this.labelage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelage.Location = new System.Drawing.Point(30, 267);
            this.labelage.Name = "labelage";
            this.labelage.Size = new System.Drawing.Size(51, 20);
            this.labelage.TabIndex = 12;
            this.labelage.Text = "age :";
            // 
            // labelstate
            // 
            this.labelstate.AutoSize = true;
            this.labelstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstate.Location = new System.Drawing.Point(30, 334);
            this.labelstate.Name = "labelstate";
            this.labelstate.Size = new System.Drawing.Size(63, 20);
            this.labelstate.TabIndex = 13;
            this.labelstate.Text = "state :";
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
            this.comboBox1.Location = new System.Drawing.Point(115, 477);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // labelsection
            // 
            this.labelsection.AutoSize = true;
            this.labelsection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsection.Location = new System.Drawing.Point(12, 480);
            this.labelsection.Name = "labelsection";
            this.labelsection.Size = new System.Drawing.Size(82, 20);
            this.labelsection.TabIndex = 16;
            this.labelsection.Text = "section :";
            // 
            // buttonaddnew
            // 
            this.buttonaddnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonaddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonaddnew.ForeColor = System.Drawing.Color.Navy;
            this.buttonaddnew.Location = new System.Drawing.Point(16, 578);
            this.buttonaddnew.Name = "buttonaddnew";
            this.buttonaddnew.Size = new System.Drawing.Size(286, 50);
            this.buttonaddnew.TabIndex = 18;
            this.buttonaddnew.Text = "add new pateint";
            this.buttonaddnew.UseVisualStyleBackColor = true;
            this.buttonaddnew.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(112, 52);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(180, 22);
            this.textBoxid.TabIndex = 20;
            this.textBoxid.Visible = false;
            this.textBoxid.TextChanged += new System.EventHandler(this.textBoxid_TextChanged);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(19, 54);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(40, 20);
            this.labelid.TabIndex = 19;
            this.labelid.Text = "ID :";
            this.labelid.Visible = false;
            this.labelid.Click += new System.EventHandler(this.labelid_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(315, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1073, 491);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // manage_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 690);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.buttonaddnew);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelsection);
            this.Controls.Add(this.labelstate);
            this.Controls.Add(this.labelage);
            this.Controls.Add(this.labeladdress);
            this.Controls.Add(this.labelphone);
            this.Controls.Add(this.textBoxphone);
            this.Controls.Add(this.textBoxaddress);
            this.Controls.Add(this.textBoxage);
            this.Controls.Add(this.textBoxstate);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttondelete);
            this.Name = "manage_patient";
            this.Text = "manage_patient";
            this.Load += new System.EventHandler(this.manage_patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxstate;
        private System.Windows.Forms.TextBox textBoxage;
        private System.Windows.Forms.TextBox textBoxaddress;
        private System.Windows.Forms.TextBox textBoxphone;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.Label labeladdress;
        private System.Windows.Forms.Label labelage;
        private System.Windows.Forms.Label labelstate;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelsection;
        private System.Windows.Forms.Button buttonaddnew;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}