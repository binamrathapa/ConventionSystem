using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConventionSystem
{
    public class Attendee
    {
        public int Id
        {
            get;
            set;
        }
       // [Required]
        public string Name
        {
            get;
            set;
        }
       // [EmailAddress]
        public string Email
        {
            get;
            set;
        }
        public string TicketType
        {
            get;
            set;
        }
        public int DaysOfAttend
        {
            get;
            set;
        }
       // [Required]
        public string Password
        {
            get;
            set;
        }

        public virtual ICollection<PresentersPerSeminar> PresentersPerSeminars
        {
            get;
            set;
        }
        public virtual ICollection<AudiencePerSeminar> AudiencePerSeminars
        {
            get;
            set;
        }

        public virtual ICollection<AttendeesPerEvent> AttendeesPerEvent
        {
            get;
            set;
        }

    }
}
