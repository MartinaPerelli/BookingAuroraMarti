using AutoMapper;
using BookingAPI.DAL.DAS.Interfaces;
using BookingAPI.Models.BookingModels;
using BookingAPI.Services.Interfaces;

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
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GetBooking> GetAll()
        {
            throw new NotImplementedException();
        }

        public Booking GetById(int id)
        {
            throw new NotImplementedException();
        }

        public GetBooking Update(int id, PutBooking book)
        {
            throw new NotImplementedException();
        }
    }
}
