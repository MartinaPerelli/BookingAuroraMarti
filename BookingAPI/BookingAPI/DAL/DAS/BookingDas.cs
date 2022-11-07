using BookingAPI.DAL.DAS.Context;
using BookingAPI.DAL.DAS.Interfaces;
using BookingAPI.Models.BookingModels;
using Microsoft.EntityFrameworkCore;

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
            _ctx.Bookings.Add(booking);
            _ctx.SaveChanges();
            return _ctx.Bookings.Include(b => b.Apartment).Include(b => b.Customer).Single(b => b.Id == booking.Id);
        }

        public void Delete(int idBooking)
        {
            var bookingToDelete = _ctx.Bookings.Single(booking => booking.Id == idBooking);
            _ctx.SaveChanges();

        }

        public IEnumerable<Booking> GetAll()
        {
           return _ctx.Bookings.Include(b => b.Apartment);
        }

        public Booking? GetById(int idBooking)
        {
            return _ctx.Bookings.Include(booking => booking.Apartment).Include(booking => booking.Customer).SingleOrDefault(booking => booking.Id == idBooking);
        }

        public Booking Update(Booking booking)
        {
           _ctx.Entry(booking).State = EntityState.Detached;
          var bookingToUpdate = GetById(booking.Id);

            bookingToUpdate.StartDate = booking.StartDate;
            bookingToUpdate.EndDate = booking.EndDate;
            bookingToUpdate.CustomerId = booking.CustomerId;
            bookingToUpdate.ApartmentId = booking.ApartmentId;

            _ctx.SaveChanges();

            return bookingToUpdate;
        }
    }
}
