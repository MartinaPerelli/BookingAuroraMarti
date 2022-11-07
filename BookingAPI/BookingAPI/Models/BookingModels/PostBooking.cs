using BookingAPI.Models.CustomerModels;

namespace BookingAPI.Models.BookingModels
{
    public class PostBooking
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int CustomerId { get; set; }
      
        public int ApartmentId { get; set; }
    }
}
