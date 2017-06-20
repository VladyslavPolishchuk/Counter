using Core.Model;
using System.Data.Entity;

namespace Core.DAL
{
    public class Context : DbContext
    {
        public Context() : base("Context") { }
        //public DbSet<Participant> Participants { get; set; }
        public DbSet<Pair> Pairs { get; set; }
        //public DbSet<Club> Clubs { get; set; }
        //public DbSet<Judge> Judges { get; set; }
        //public DbSet<Tournament> Tournaments { get; set; }
    }
}
