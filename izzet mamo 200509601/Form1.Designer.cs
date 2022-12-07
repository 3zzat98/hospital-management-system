namespace izzet_mamo_200509601
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "user name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "password :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonlogin.Location = new System.Drawing.Point(328, 284);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(75, 36);
            this.buttonlogin.TabIndex = 2;
            this.buttonlogin.Text = "log in";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(358, 222);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.PasswordChar = '*';
            this.textBoxpassword.Size = new System.Drawing.Size(171, 22);
            this.textBoxpassword.TabIndex = 3;
            this.textBoxpassword.TextChanged += new System.EventHandler(this.textBoxpassword_TextChanged);
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(358, 138);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(171, 22);
            this.textBoxusername.TabIndex = 4;
            this.textBoxusername.TextChanged += new System.EventHandler(this.textBoxusername_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.TextBox textBoxusername;
    }
}

