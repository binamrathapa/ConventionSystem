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
    public partial class RegisterAttendee : Form
    {
        ConventionSystemContext db = new ConventionSystemContext();

        public RegisterAttendee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Attendee attendee = new Attendee();
                attendee.Name = txtName.Text;
                attendee.Email = txtEmail.Text;
                attendee.Password = txtPassword.Text;
                attendee.TicketType = cbTicketType.SelectedItem.ToString();
                attendee.DaysOfAttend = Convert.ToInt32(txtAttendDays.Text);
                db.Attendees.Add(attendee);
                db.SaveChanges();
                MessageBox.Show("Added successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
