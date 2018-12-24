using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionSystem
{
    public class PresentersPerSeminar
    {
        public int Id
        {
            get;
            set;
        }
        public int AttendeeId
        {

            get;
            set;
        }
        public int SeminarId
        {
            get;
            set;
        }

        public virtual Seminar Seminar
        {
            get;
            set;
        }

        public virtual Attendee Presenter
        {
            get;
            set;
        }
    }
}
