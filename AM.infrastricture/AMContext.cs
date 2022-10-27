using Microsoft.EntityFrameworkCore;
using AM.ApplicationCore.Domain;

namespace AM.infrastricture
{
    public class AMContext : DbContext 
    {
        DbSet<Passenger> Passengers { get; set; }
        DbSet<Flight> Flights { get; set; }
        DbSet<Plane> PLanes { get; set; }
        DbSet<Staff> Staffs { get; set; }
        DbSet<Traveller> Travellers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source = (localDb)\msSqlLocalDb; initial catalog = AirPortManagementDb; integrated security = true");
        }

    }
}