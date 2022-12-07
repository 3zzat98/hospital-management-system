using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace izzet_mamo_200509601
{
    public partial class adddoktor : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-VBGFGG8;DataBase=hospital;Integrated Security=true");
        public adddoktor()
        {
            InitializeComponent();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into doctor values('" + textBoxname.Text + "','" + textBoxphone.Text + "','" + comboBox1.Text + "','" + textBoxaddress.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("basarli hoca eklendi");
            textBoxaddress.Text = "";
            textBoxname.Text = "";
            textBoxphone.Text = "";
        }

        private void adddoktor_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void labeladdres_Click(object sender, EventArgs e)
        {

        }

        private void textBoxphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelsection_Click(object sender, EventArgs e)
        {

        }

        private void labelphone_Click(object sender, EventArgs e)
        {

        }

        private void labelname_Click(object sender, EventArgs e)
        {

        }
    }
}
