using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izzet_mamo_200509601
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void doktorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewDoktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adddoktor f = new adddoktor();
            f.Show();
        }

        private void manageDoktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managedoktor f = new managedoktor();
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manage_patient frm = new manage_patient();
            frm.Show();
        }
    }
}
