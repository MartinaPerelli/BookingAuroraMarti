using BookingAPI.Models.ApartmentModels;

namespace BookingAPI.Services.Interfaces
{
    public interface IApartmentService : IServiceCrud<Apartment,PostApartment,GetApartment,PutApartment>
    {
    }
}
