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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using System.Data;
using System.Data.SqlClient;

namespace izzet_mamo_200509601
{
    public partial class editdoctor : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-VBGFGG8;DataBase=hospital;Integrated Security=true");
        public editdoctor()
        {
            InitializeComponent();
        }

        private void editdoctor_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelid_Click(object sender, EventArgs e)
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
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update doctor set name='" + textBoxname.Text + "',phone='" + textBoxaddress.Text + "',email='" + textBoxphone.Text + "',section='" + comboBox1.Text + "'where id='" + Convert.ToInt32(textBox1.Text) + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("edit info successfully..");
        }
    }
}
