using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Data.Entity;

namespace ConventionSystem
{
    public partial class AddSeminar : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        List<int> attendeeIds = new List<int>();
        List<int> presenterIds = new List<int>();
        bool isAudienceAdded = false;
        bool isPresenterAdded = false;
        int seminarId = 0;
        public AddSeminar(int pSeminarId)
        {
            InitializeComponent();
            seminarId = pSeminarId;
        }

        private void AddSeminar_Load(object sender, EventArgs e)
        {
            cbTimeFormat.SelectedIndex = 0;
            cbRoom.DisplayMember = "Location";
            cbRoom.ValueMember = "Id";
            cbRoom.DataSource = db.RoomStallLocations.ToList();
            LoadSeminar(seminarId);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInputs(txtTitle))
                {
                    throw new Exception("Please enter Title");
                }
                //if (!CheckInputs(txtRoomSize))
                //{
                //    throw new Exception("Please enter Room Size");
                //}
                if (!CheckInputs(txtDuration))
                {
                    throw new Exception("Please enter Duration");
                }
                Seminar seminar;
                List<AudiencePerSeminar> audiencePerSeminars=new List<AudiencePerSeminar>();
                List<PresentersPerSeminar> presentersPerSeminars=new List<PresentersPerSeminar>();
                if (seminarId > 0)
                {
                    seminar = db.Seminars.Find(seminarId);
                    audiencePerSeminars = seminar.AudiencePerSeminars;
                    presentersPerSeminars = seminar.PresentersPerSeminars;
                }
                else
                {
                    seminar = new Seminar();
                    //audiencePerSeminars = new List<AudiencePerSeminar>();
                    //presentersPerSeminars = new List<PresentersPerSeminar>();
                }
                seminar.Title = txtTitle.Text;
                seminar.SeminarDateTime = GetSeminarStartDateTime();
                seminar.RoomStallLocation = db.RoomStallLocations.Find(Convert.ToInt32(cbRoom.SelectedValue));
                seminar.Duration = Convert.ToInt32(txtDuration.Text);
                               

                foreach (int id in attendeeIds)
                {
                    AudiencePerSeminar audiencePerSeminar = new AudiencePerSeminar();
                    audiencePerSeminar.Attendee = db.Attendees.Find(id);
                    audiencePerSeminar.Seminar = seminar;
                   var attendee = audiencePerSeminars.Where(aps => aps.AttendeeId == id);

                   if (attendee == null)                    
                        audiencePerSeminars.Add(audiencePerSeminar);
                    
                }

                foreach (int id in presenterIds)
                {
                    PresentersPerSeminar presentersPerSeminar = new PresentersPerSeminar();
                    presentersPerSeminar.Presenter = db.Attendees.Find(id);
                    presentersPerSeminar.Seminar = seminar;
                    //var presenter = presentersPerSeminars.Where(aps => aps.AttendeeId == id);
                    //if (presenter == null)
                        presentersPerSeminars.Add(presentersPerSeminar);
                }

                if (audiencePerSeminars.Count < 1)
                {
                    throw new Exception("Please add Audience");
                }
                if (presentersPerSeminars.Count < 1)
                {
                    throw new Exception("Please add Presenter");
                }

                seminar.AudiencePerSeminars = audiencePerSeminars;
                if (seminar.AudiencePerSeminars.Count > db.RoomStallLocations.Find(cbRoom.SelectedValue).Capacity)
                {
                    throw new Exception("Room Capacity is Full");
                }
                seminar.PresentersPerSeminars = presentersPerSeminars;
                if (seminarId > 0)
                {
                    db.Seminars.Attach(seminar);
                }
                else
                    db.Seminars.Add(seminar);
                db.SaveChanges();
                MessageBox.Show("Seminar successfully added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAudience_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = GetSeminarStartDateTime();
                DateTime endDate = GetSeminarEndDateTime();
                var bookedAttendees = (from a in db.Attendees
                                       join aps in db.AudiencePerSeminars on a.Id equals aps.AttendeeId
                                       join s in db.Seminars on aps.SeminarId equals s.Id
                                       where (s.SeminarDateTime >= startDate && s.SeminarDateTime <= endDate)
                                       select new { a.Id, a.Name, a.Email }).ToList();

                var allAttendees = (from a in db.Attendees select new {a.Id, a.Name, a.Email }).ToList();
                var avialableAudience = allAttendees.Except(bookedAttendees).ToList();

                //var tt = db.AudiencePerSeminars.Where(aps => aps.Seminar.SeminarDateTime > startDate && aps.Seminar.SeminarDateTime < endDate).Select(a => a.Attendee);//.FirstOrDefault();
                //var avialableAttendees = db.Attendees.Where(a => a.Id != (a.AudiencePerSeminars.Where(aps => aps.Seminar.SeminarDateTime >= startDate && aps.Seminar.SeminarDateTime <= endDate).Select(attendee => attendee.Attendee).FirstOrDefault().Id)).ToList();
                //dataGridView1.DataSource = avialableAudience;
                SavePresenterAutience.Text = "Save Audience";

                if (seminarId > 0)
                {


                    //var chk = Convert.ToBoolean(drv.Cells["chkSelect"].Value);
                    //int attendeeId = Convert.ToInt32(drv.Cells["Id"].Value);
                    //var chkSelect = drv.Cells["chkSelect"];
                    var selectedAudience = db.AudiencePerSeminars.Where(aps => aps.SeminarId == seminarId).Select(a => a.Attendee).ToList();
                    var tempAudience = (from attendee in selectedAudience select new { attendee.Id, attendee.Name, attendee.Email }).ToList();

                    dataGridView1.Controls.Clear();

                    foreach (var at in tempAudience)
                    {
                        var t = avialableAudience.Where(a => a.Id == at.Id).FirstOrDefault();
                        if (t == null)
                            avialableAudience.Add(at);
                    }
                    dataGridView1.DataSource = avialableAudience;
                    
                    foreach (DataGridViewRow drv in dataGridView1.Rows)
                    {
                        int attendeeId = Convert.ToInt32(drv.Cells["Id"].Value);
                        var chkSelect = drv.Cells["chkSelect"];
                        var attendee= tempAudience.Where(a => a.Id == attendeeId).FirstOrDefault();
                        if (attendee != null)
                            chkSelect.Value = true;
                    }


                }
                isAudienceAdded = true;
                isPresenterAdded = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnPresenter_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Controls.Clear();
                DateTime startDate = GetSeminarStartDateTime();
                DateTime endDate = GetSeminarEndDateTime();
                var bookedPresenters = (from a in db.Attendees
                                        join pps in db.PresentersPerSeminars on a.Id equals pps.AttendeeId
                                        join s in db.Seminars on pps.SeminarId equals s.Id
                                        where (s.SeminarDateTime >= startDate && s.SeminarDateTime <= endDate)
                                        select new { a.Id, a.Name, a.Email }).ToList();

                var allPresenters = (from a in db.Attendees select new { a.Id, a.Name, a.Email }).ToList();
                var freePresenters = allPresenters.Except(bookedPresenters).ToList();

                //var avialableAttendees = db.Attendees.Where(a => a.Id != (a.PresentersPerSeminars.Where(aps => aps.Seminar.SeminarDateTime > startDate && aps.Seminar.SeminarDateTime < endDate).Select(attendee => attendee.Presenter).FirstOrDefault().Id)).ToList();
                dataGridView1.DataSource = freePresenters;
                SavePresenterAutience.Text = "Save Presenter";

                if (seminarId > 0)
                {
                    var selectedPresenters = db.PresentersPerSeminars.Where(aps => aps.SeminarId == seminarId).Select(a => a.Presenter).ToList();
                    var tempPresenters = (from attendee in selectedPresenters select new { attendee.Id, attendee.Name, attendee.Email }).ToList();

                    dataGridView1.Controls.Clear();

                    foreach (var at in tempPresenters)
                    {
                        var t = allPresenters.Where(a => a.Id == at.Id).FirstOrDefault();
                        if (t == null)
                            allPresenters.Add(at);
                    }
                    dataGridView1.DataSource = allPresenters;

                    foreach (DataGridViewRow drv in dataGridView1.Rows)
                    {
                        int attendeeId = Convert.ToInt32(drv.Cells["Id"].Value);
                        var chkSelect = drv.Cells["chkSelect"];
                        var attendee = tempPresenters.Where(a => a.Id == attendeeId).FirstOrDefault();
                        if (attendee != null)
                            chkSelect.Value = true;
                    }
                }

                isPresenterAdded = true;
                isAudienceAdded = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DateTime GetSeminarStartDateTime()
        {
            if (!CheckInputs(txtTime))
            {
                throw new Exception("Please enter Time in appropriate format");
            }

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

        private bool CheckInputs(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void SavePresenterAutience_Click(object sender, EventArgs e)
        {
            bool isSelected = false;

            foreach (DataGridViewRow drv in dataGridView1.Rows)
            {
                var chk = Convert.ToBoolean(drv.Cells["chkSelect"].Value);

                if (chk)
                {
                    isSelected = true;
                    if (isAudienceAdded)
                        attendeeIds.Add(Convert.ToInt32(drv.Cells["Id"].Value));
                    if (isPresenterAdded)
                        presenterIds.Add(Convert.ToInt32(drv.Cells["Id"].Value));
                }

            }
            if (!isSelected)
                MessageBox.Show("There is no Audience selected");
            else
                MessageBox.Show("Attendees successfully added into seminar");
        }

        private void LoadSeminar(int pSeminarId)
        {
            var seminar = db.Seminars.Find(pSeminarId);
            txtTitle.Text = seminar.Title;
            txtTime.Text = seminar.SeminarDateTime.Hour.ToString() + ":" + seminar.SeminarDateTime.Minute.ToString();
            txtDuration.Text = seminar.Duration.ToString();
            cbRoom.SelectedValue = seminar.RoomStallLocationId;

        }
    }

}
