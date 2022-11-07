using AutoMapper;
using BookingAPI.Models.CustomerModels;

namespace BookingAPI.MapperProfiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, PostCustomer>().ReverseMap();
            CreateMap<Customer, GetCustomer>().ReverseMap();
            CreateMap<Customer, PutCustomer>().ReverseMap();
        }
    }
}
