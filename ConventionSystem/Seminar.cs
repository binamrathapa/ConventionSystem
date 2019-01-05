using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionSystem
{
    public class Seminar
    {
        //Title, time and date, which attendees are presenting, 
        //size of room required, duration and which attendees are registered for the audience
        public int Id
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public DateTime SeminarDateTime
        {
            get;
            set;
        }

        public int RoomSize
        {
            get;
            set;
        }
        public decimal Duration
        {
            get;
            set;
        }
        public int RoomStallLocationId
        { get; set; }

        public virtual List<PresentersPerSeminar> PresentersPerSeminars
        {
            get;
            set;
        } //= new List<PresentersPerSeminar>();

        public virtual List<AudiencePerSeminar> AudiencePerSeminars
        {
            get;
            set;
        }// = new List<AudiencePerSeminar>();

        public virtual RoomStallLocation RoomStallLocation
        { get; set; }
        
    }
}
