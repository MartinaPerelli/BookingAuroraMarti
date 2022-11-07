using BookingAPI.DAL.DAS.Context;
using BookingAPI.DAL.DAS.Interfaces;
using BookingAPI.Models.ApartmentModels;
using Microsoft.EntityFrameworkCore;

namespace BookingAPI.DAL.DAS
{
    public class ApartmentDas : IApartmentDas
    {
        private readonly BookingAMContext _ctx;

        public ApartmentDas(BookingAMContext ctx)
        {
            _ctx = ctx;
        }

        public Apartment Add(Apartment apartment)
        {
            _ctx.Apartments.Add(apartment);
            _ctx.SaveChanges();
            return apartment;
        }

        public IEnumerable<Apartment> GetAll()
        {
            return _ctx.Apartments;
        }

        public Apartment? GetById(int idApartment)
        {
            return _ctx.Apartments.SingleOrDefault(apartment => apartment.Id == idApartment);
        }

        public Apartment Update(Apartment apartment)
        {
            _ctx.Entry(apartment).State = EntityState.Detached;
            var apartmentToUpdate = GetById(apartment.Id);

            apartmentToUpdate.Address = apartment.Address;
            apartmentToUpdate.Name = apartment.Name;
            apartmentToUpdate.Sqm = apartment.Sqm;

            _ctx.SaveChanges();

            return apartmentToUpdate;
        }
    }
}
