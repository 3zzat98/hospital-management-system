using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace izzet_mamo_200509601
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-VBGFGG8;DataBase=hospital;Integrated Security=true");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from users where username='"+textBoxusername.Text+"' and password='"+textBoxpassword.Text+"'",con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("welcome to database of hospital");
                home f = new home();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("username or password is wrong....!!");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
