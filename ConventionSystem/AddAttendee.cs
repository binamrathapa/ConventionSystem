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
    public partial class AddAttendee : Form
    {
        public AddAttendee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConventionSystemContext db = new ConventionSystemContext();
                Attendee attendee = new Attendee();
                attendee.Name = textBox1.Text;
                attendee.Email = textBox2.Text;
                attendee.TicketType = textBox3.Text;
                attendee.DaysOfAttend = Convert.ToInt32(textBox4.Text);
                db.Attendees.Add(attendee);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
