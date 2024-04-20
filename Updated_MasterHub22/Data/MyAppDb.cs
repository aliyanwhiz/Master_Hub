using DashBoard2.Models;
using Microsoft.EntityFrameworkCore;

namespace DashBoard2.Data
{
    public class MyAppDb : DbContext
    {
        public MyAppDb(DbContextOptions<MyAppDb>options) : base(options)
        {
        }

        public DbSet<Admin> tbl_adm1 { get; set; }
        public DbSet<Customer> tbl_cus1 { get; set; }
        public DbSet<City> tbl_city { get; set; }
        public DbSet<Services> tbl_services { get; set; }
        public DbSet<Partner> tbl_part { get; set; }
        public DbSet<Feedback> tbl_feed { get; set; }
        public DbSet<Booking> tbl_booking { get; set; }
        public DbSet<Bookingservice> tbl_bookingservice { get; set; }

    }
}
