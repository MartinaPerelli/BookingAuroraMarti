using BookingAPI.Models.ApartmentModels;

namespace BookingAPI.DAL.DAS.Interfaces
{
    public interface IApartmentDas
    {
        public Apartment Add(Apartment apartment);
        public Apartment? GetById(int idApartment);
        public IEnumerable<Apartment> GetAll();
        public Apartment Update(Apartment apartment);
    }
}
