using BookingAPI.Models.ApartmentModels;
using BookingAPI.Models.CustomerModels;
namespace BookingAPI.Models.BookingModels
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
    }
}
