using BookingAPI.DAL.DAS.Context;
using BookingAPI.DAL.DAS.Interfaces;
using BookingAPI.Models.ApartmentModels;

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
            throw new NotImplementedException();
        }

        public IEnumerable<Apartment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Apartment GetById(int idApartment)
        {
            throw new NotImplementedException();
        }

        public Apartment Update(Apartment apartment)
        {
            throw new NotImplementedException();
        }
    }
}
