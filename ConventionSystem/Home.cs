using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConventionSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addSeminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddSeminar frmAddSeminar = new AddSeminar();
            frmAddSeminar.Show();
        }

        private void addSeminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAttendee frmAddAttendee = new AddAttendee();
            frmAddAttendee.Show();
        }
    }
}
