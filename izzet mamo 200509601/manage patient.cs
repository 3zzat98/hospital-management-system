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
    public partial class manage_patient : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-VBGFGG8;DataBase=hospital;Integrated Security=true");
        public manage_patient()
        {
            InitializeComponent();
            buttonupdate.Enabled= false;
            SqlDataAdapter ad = new SqlDataAdapter("select * from patient", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;
        }

        private void manage_patient_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into patient values('" + textBoxname.Text + "','" + textBoxphone.Text + "','" + textBoxaddress.Text + "','" + Convert.ToInt32(textBoxage.Text) + "','"+textBoxstate.Text+"','"+comboBox1.Text+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("add patient successfully");

            textBoxage.Text = "";
            textBoxaddress.Text = "";
            textBoxname.Text = "";
            textBoxstate.Text = "";
            textBoxphone.Text = "";

            SqlDataAdapter ad = new SqlDataAdapter("select * from patient", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure yor want to delete row !!") == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand("delete from patient where id='" + Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("delete successfully....");

                SqlDataAdapter ad = new SqlDataAdapter("select * from patient", con);
                DataTable d = new DataTable();
                ad.Fill(d);
                dataGridView1.DataSource = d;
            }
        }

        private void textBoxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelid_Click(object sender, EventArgs e)
        {

        }

        private void textBoxphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update patient set name='" + textBoxname.Text + "',phone='" + textBoxphone.Text + "',address='" + textBoxaddress.Text + "',age='" + Convert.ToInt32(textBoxage.Text) + "',state='" + textBoxstate.Text + "',section='" + comboBox1.Text + "'where id='" + Convert.ToInt32(textBoxid.Text) + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("edit info successfully..", "update data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            SqlDataAdapter ad = new SqlDataAdapter("select * from patient", con);
            DataTable d = new DataTable();
            ad.Fill(d);
            dataGridView1.DataSource = d;

            textBoxid.Visible = false;
            labelid.Visible = true;

            textBoxname.Text = "";
            textBoxphone.Text = "";
            textBoxstate.Text = "";
            textBoxaddress.Text = "";
            textBoxage.Text = "";

            buttonaddnew.Enabled = false;
            buttonupdate.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxid.Visible = true;
            labelid.Visible = true;
            buttonaddnew.Enabled = false;

            textBoxid.Text = dataGridView1.CurrentRow.Cells[0].Visible.ToString();

            textBoxname.Text = dataGridView1.CurrentRow.Cells[1].Visible.ToString();

            textBoxphone.Text = dataGridView1.CurrentRow.Cells[2].Visible.ToString();

            textBoxaddress.Text = dataGridView1.CurrentRow.Cells[3].Visible.ToString();

            textBoxage.Text = dataGridView1.CurrentRow.Cells[4].Visible.ToString();

            textBoxstate.Text = dataGridView1.CurrentRow.Cells[5].Visible.ToString();

            comboBox1.Text = dataGridView1.CurrentRow.Cells[6].Visible.ToString();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBoxid.Visible = true;
            labelid.Visible = true;
            buttonaddnew.Enabled = false;
            buttonupdate.Enabled = true;

            textBoxid.Text = dataGridView1.CurrentRow.Cells[0].Visible.ToString();

            textBoxname.Text = dataGridView1.CurrentRow.Cells[1].Visible.ToString();

            textBoxphone.Text = dataGridView1.CurrentRow.Cells[2].Visible.ToString();

            textBoxaddress.Text = dataGridView1.CurrentRow.Cells[3].Visible.ToString();

            textBoxage.Text = dataGridView1.CurrentRow.Cells[4].Visible.ToString();

            textBoxstate.Text = dataGridView1.CurrentRow.Cells[5].Visible.ToString();

            comboBox1.Text = dataGridView1.CurrentRow.Cells[6].Visible.ToString();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
