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
    public partial class AddSeminar : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();

        public AddSeminar()
        {
            InitializeComponent();
        }

        private void AddSeminar_Load(object sender, EventArgs e)
        {
            cbTimeFormat.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Seminar seminar = new Seminar();

                seminar.Title = txtTitle.Text;
                seminar.SeminarDateTime = GetSeminarStartDateTime();
                seminar.RoomSize = Convert.ToInt32(txtRoomSize.Text);
                seminar.Duration = Convert.ToInt32(txtDuration.Text);

                db.Seminars.Add(seminar);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var vv = db.Attendees.ToList();
            DateTime startDate = GetSeminarStartDateTime();
            DateTime endDate = GetSeminarEndDateTime();
            //var tt = db.AudiencePerSeminars.Where(aps => aps.Seminar.SeminarDateTime > startDate && aps.Seminar.SeminarDateTime < endDate).Select(a => a.Attendee);//.FirstOrDefault();
            var avialableAttendees = db.Attendees.Where(a=>a.Id != (db.AudiencePerSeminars.Where(aps => aps.Seminar.SeminarDateTime > startDate && aps.Seminar.SeminarDateTime < endDate).Select(attendee => attendee.Attendee).FirstOrDefault().Id)).ToList();
            dataGridView1.DataSource = avialableAttendees;
        }

        private DateTime GetSeminarStartDateTime()
        {
            string[] times = txtTime.Text.Split(':');

            int hour = Convert.ToInt32(times[0]);
            if (hour > 12)
            {
                throw new Exception("Hour can not greater than 12");
            }
            if (cbTimeFormat.SelectedItem.ToString() == "PM")
            {
                hour += 12;
            }
            DateTime temp = dtSeminarDate.Value.Date;
            int minute = Convert.ToInt32(times[1]);
            return new DateTime(temp.Year, temp.Month, temp.Day, hour, minute, 0);
        }

        private DateTime GetSeminarEndDateTime()
        {
            return GetSeminarStartDateTime().AddHours(Convert.ToInt32(txtDuration.Text));
        }
    }


}
