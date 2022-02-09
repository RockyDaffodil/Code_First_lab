using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_lab
{
    class OlympicContext:DbContext
    {
        public OlympicContext(): base("ConnStr")
        {
            Database.SetInitializer<OlympicContext>(new MyInitalizer());
        }
        public DbSet<Participants> Participants { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<NameOfsSports> NameOfsSports { get; set; }
        public DbSet<Conducting> Conducting { get; set; }
        public DbSet<Summer_Winter_Olymp> Summer_Winter_Olymp { get; set; }
        public DbSet<ConductingParticipants> conductingParticipants { get; set; }
        public DbSet<Medal_Count> medal_Counts { get; set; }
    }
    class MyInitalizer : CreateDatabaseIfNotExists<OlympicContext>
    {
        protected override void Seed(OlympicContext db)
        {
            Summer_Winter_Olymp s = (new Summer_Winter_Olymp() { NameWinter = "Summer" });
            db.Summer_Winter_Olymp.Add(s);
            db.SaveChanges();
            Summer_Winter_Olymp s1 = (new Summer_Winter_Olymp() { NameWinter = "Winter" });
            db.Summer_Winter_Olymp.Add(s1);
            db.SaveChanges();
        }
    }
}
