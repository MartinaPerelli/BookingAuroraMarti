using AutoMapper;
using BookingAPI.Models.BookingModels;

namespace BookingAPI.MapperProfiles
{
    public class BookingProfile : Profile
    {
        public BookingProfile()
        {
            CreateMap<Booking, PostBooking>().ReverseMap();
            CreateMap<Booking, GetBooking>().ReverseMap();
            CreateMap<Booking, PutBooking>().ReverseMap();
        }
    }
}
