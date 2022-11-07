using BookingAPI.Models.BookingModels;

namespace BookingAPI.DAL.DAS.Interfaces
{
    public interface IBookingDas
    {
        public Booking Add(Booking booking);
        public Booking? GetById(int idBooking);
        public IEnumerable<Booking> GetAll();
        public Booking Update(Booking booking);

        public void Delete(int idBooking);

    }
}
