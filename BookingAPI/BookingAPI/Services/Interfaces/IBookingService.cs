using BookingAPI.Models.BookingModels;

namespace BookingAPI.Services.Interfaces
{
    public interface IBookingService : IServiceCrud<Booking,PostBooking,GetBooking,PutBooking>
    {
    }
}
