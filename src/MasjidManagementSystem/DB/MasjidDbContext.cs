using Microsoft.EntityFrameworkCore;
using MasjidManagementSystem.Models;

namespace MasjidManagementSystem.DB
{
    public class MasjidDbContext : DbContext
    {
        public MasjidDbContext(DbContextOptions<MasjidDbContext> options):base(options)
        {

        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Imam> Imams { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<PrayerSchedule> Prayers { get; set; }

    }
}
