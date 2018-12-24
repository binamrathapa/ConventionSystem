using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionSystem
{
    public class Stall
    {
        public int Id
        {
            get;
            set;
        }
        public string LocationCode
        {
            get;
            set;
        }
        public int Size
        {
            get;
            set;
        }

        public DateTime StartDate
        {
            get;
            set;
        }
        public DateTime EndDate
        {
            get;
            set;
        }

        public string StallType
        {
            get;
            set;
        }
    }
}
