using AutoMapper;
using BookingAPI.Models.ApartmentModels;

namespace BookingAPI.MapperProfiles
{
    public class ApartmentProfile : Profile
    {
        public ApartmentProfile()
        {
            CreateMap<Apartment,PostApartment>().ReverseMap();
            CreateMap<Apartment,PutApartment>().ReverseMap();
            CreateMap<Apartment,GetApartment>().ReverseMap();
        }
    }
}
