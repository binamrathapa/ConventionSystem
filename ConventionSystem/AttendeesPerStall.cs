using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionSystem
{
    public class AttendeesPerStall
    {
        public int Id
        { get; set; }

        public int AttendeeId
        { get; set; }

        public int StallId
        { get; set; }

        public DateTime AttendeeExhibitDate
        { get; set; }
    }
}
