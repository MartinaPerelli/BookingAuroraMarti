using BookingAPI.Models.ApartmentModels;

namespace BookingAPI.Models.BookingModels
{
    public class GetModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Apartment Apartment { get; set; }
    }
}
