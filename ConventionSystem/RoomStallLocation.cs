using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionSystem
{
    public class RoomStallLocation
    {
        public int Id
        {
            get;
            set;
        }
        public string Location
        {
            get;
            set;
        }
        public int Capacity
        {
            get;
            set;
        }
        public string Resource
        {
            get;
            set;
        }

        
        
        public virtual ICollection<Seminar> Seminars
        { get; set; }

    }
}
