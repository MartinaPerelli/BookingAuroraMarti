using BookingAPI.Models.ApartmentModels;
using BookingAPI.Models.BookingModels;
using BookingAPI.Models.CustomerModels;
using Microsoft.EntityFrameworkCore;

namespace BookingAPI.DAL.DAS
{
    public class BookingAMContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Apartment> Apartments  { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public BookingAMContext(DbContextOptions<BookingAMContext> options) : base(options)
        {

        }
    }
}
