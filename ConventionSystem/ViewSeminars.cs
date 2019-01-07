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
using System.Data.Entity.Validation;

namespace ConventionSystem
{
    public partial class ViewSeminars : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();
        public ViewSeminars()
        {
            InitializeComponent();
        }

        private void ViewSeminars_Load(object sender, EventArgs e)
        {
            LoadSeminars();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string command = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (command.ToLower() == "delete")
                {
                    try
                    {
                        if (MessageBox.Show("Are you sure to Delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var seminar = db.Seminars.Where(ss=>ss.Id==id).Include(s => s.AudiencePerSeminars).Include(s => s.PresentersPerSeminars).Include(s => s.RoomStallLocation).FirstOrDefault();
                            //db.Entry(seminar).State = EntityState.Deleted;
                            db.Seminars.Remove(seminar);
                            db.SaveChanges();
                            MessageBox.Show("Seminar Successfully deleted");
                            LoadSeminars();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    

                }
                else if (command.ToLower() == "edit")
                {
                    AddSeminar addSeminar = new AddSeminar(id);
                    addSeminar.Show();
                }
            }
        }

        private void LoadSeminars()
        {
            var seminars = (from s in db.Seminars select new { s.RoomStallLocation.Location, s.SeminarDateTime, s.Duration, s.Id,s.Title} ).ToList();
            dataGridView1.DataSource = seminars;
        }
    }
}
