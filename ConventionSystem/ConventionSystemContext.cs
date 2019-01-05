using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventionSystem
{
    public partial class ConventionSystemContext:DbContext
    {        
        public virtual DbSet<Seminar> Seminars { get; set; }
        public virtual DbSet<Attendee> Attendees { get; set; }

        public virtual DbSet<AudiencePerSeminar> AudiencePerSeminars { get; set; }

        public virtual DbSet<PresentersPerSeminar> PresentersPerSeminars { get; set; }
        public virtual DbSet<RoomStallLocation> RoomStallLocations { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            this.Configuration.LazyLoadingEnabled = false;
           this.Configuration.ProxyCreationEnabled = false;
            
        }
    }
}
