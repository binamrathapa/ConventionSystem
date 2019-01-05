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
    public partial class AttendeeSchedule : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        public AttendeeSchedule()
        {
            InitializeComponent();
        }

        private void AttendeeSchedule_Load(object sender, EventArgs e)
        {
            var mySeminars = (from a in db.Attendees
                     join aps in db.AudiencePerSeminars on a.Id equals aps.AttendeeId
                     join s in db.Seminars on aps.SeminarId equals s.Id
                     where aps.AttendeeId==2
                     select new {Type="Seminar",s.Title,s.SeminarDateTime,s.Duration,s.RoomStallLocation.Location,s.RoomStallLocation.Resource }).ToList();
            //var myEvents=
            dataGridView1.DataSource = mySeminars;
        }
    }
}
