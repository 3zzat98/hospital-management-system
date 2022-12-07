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
using System.Data.SqlClient;
using System.Data;
namespace izzet_mamo_200509601
{
    public partial class managedoktor : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-VBGFGG8;DataBase=hospital;Integrated Security=true");
        public managedoktor()
        {
            InitializeComponent();
            SqlDataAdapter ad= new SqlDataAdapter("select * from doctor",con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd= new SqlCommand("delete from doctor where id='" +Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) +"'",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("delete successfully....");

            SqlDataAdapter ad = new SqlDataAdapter("select * from doctor", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            editdoctor f = new editdoctor();
            f.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f.textBoxname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f.textBoxphone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f.comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f.textBoxaddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f.Show();
        }
    }
}
