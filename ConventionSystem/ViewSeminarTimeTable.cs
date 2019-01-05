using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ConventionSystem
{
    public partial class ViewSeminarTimeTable : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        public ViewSeminarTimeTable()
        {
            InitializeComponent();
        }

        private void ViewSeminarTimeTable_Load(object sender, EventArgs e)
        {
            var seminars = (from s in db.Seminars select new { s.Title, s.SeminarDateTime,s.Duration, NumbersOfAttendees = s.AudiencePerSeminars.Count,s.RoomStallLocation.Location,s.RoomStallLocation.Capacity,s.RoomStallLocation.Resource }).ToList();
            dataGridView1.DataSource = seminars;

            //db.Seminars.Include(s=>s.)
        }
    }
}
