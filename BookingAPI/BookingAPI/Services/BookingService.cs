using AutoMapper;
using BookingAPI.DAL.DAS.Interfaces;
using BookingAPI.Models.BookingModels;
using BookingAPI.Services.Interfaces;
using BookingAPI.Utilities;

namespace BookingAPI.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingDas _bookingDas;
        private readonly IMapper _mapper;

        public BookingService(IBookingDas bookingDas, IMapper mapper)
        {
            _bookingDas = bookingDas;
            _mapper = mapper;
        }

        public Booking Create(PostBooking objectValue)
        {
            if(!_bookingDas.GetAll().isBookingAvailable(objectValue))
            {
                throw new ArgumentException($"This apartment is not available for this dates:{objectValue.StartDate},{objectValue.EndDate}");
            }
            var bookingToAdd = _mapper.Map<Booking>(objectValue);
            return _bookingDas.Add(bookingToAdd);
        }

        public void DeleteById(int id)
        {
            _bookingDas.Delete(id);
        }

        public IEnumerable<GetBooking> GetAll()
        {
            var getBookings = _bookingDas.GetAll();
            return _mapper.Map<List<GetBooking>>(getBookings);
        }

        public Booking GetById(int id)
        {
            var booking = _bookingDas.GetById(id);
            if(booking == null)
            {
                throw new ArgumentException($"No booking found with such id {id}");
            }
            return booking;
        }

        public GetBooking Update(int id, PutBooking objectValue)
        {
            var bookingToUpdate = new Booking
            {
                StartDate = objectValue.StartDate,
                EndDate = objectValue.EndDate
            };

            var bookingUpdated = _bookingDas.Update(bookingToUpdate);
            return _mapper.Map<GetBooking>(bookingUpdated);
        }
    }
}
