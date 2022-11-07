using AutoMapper;
using BookingAPI.DAL.DAS.Interfaces;
using BookingAPI.Models.ApartmentModels;
using BookingAPI.Services.Interfaces;

namespace BookingAPI.Services
{
    public class ApartmentService : IApartmentService
    {
        private readonly IApartmentDas _apartmentDas;
        private readonly IMapper _mapper;
        public ApartmentService(IApartmentDas apartmentDas, IMapper mapper)
        {
            _apartmentDas = apartmentDas;
            _mapper = mapper;
        }

        public Apartment Create(PostApartment objectValue)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GetApartment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Apartment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public GetApartment Update(int id, PutApartment book)
        {
            throw new NotImplementedException();
        }
    }
}
