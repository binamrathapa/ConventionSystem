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
            AddSeminar frmAddSeminar = new AddSeminar(0);
            frmAddSeminar.Show();
        }

        private void addSeminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterAttendee registerAttendee = new RegisterAttendee();
            registerAttendee.Show();
        }

        private void viewSeminarTimetableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSeminarTimeTable viewSeminarTimeTable = new ViewSeminarTimeTable();
            viewSeminarTimeTable.Show();
        }

        private void viewScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttendeeSchedule attendeeSchedule = new AttendeeSchedule();
            attendeeSchedule.Show();
        }

        private void displaySeminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewSeminars viewSeminars = new ViewSeminars();
            viewSeminars.Show();
        }
    }
}
