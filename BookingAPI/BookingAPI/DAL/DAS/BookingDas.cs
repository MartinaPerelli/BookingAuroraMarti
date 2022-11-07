using BookingAPI.DAL.DAS.Context;
using BookingAPI.DAL.DAS.Interfaces;
using BookingAPI.Models.BookingModels;

namespace BookingAPI.DAL.DAS
{
    public class BookingDas : IBookingDas
    {
        private readonly BookingAMContext _ctx;
        public BookingDas(BookingAMContext ctx)
        {
            _ctx = ctx;
        }
        public Booking Add(Booking booking)
        {
            throw new NotImplementedException();
        }

        public void Delete(int idBooking)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Booking> GetAll()
        {
            throw new NotImplementedException();
        }

        public Booking GetById(int idBooking)
        {
            throw new NotImplementedException();
        }

        public Booking Update(Booking booking)
        {
            throw new NotImplementedException();
        }
    }
}
