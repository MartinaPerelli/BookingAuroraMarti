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
            var apartmentToAdd = _mapper.Map<Apartment>(objectValue);
            return _apartmentDas.Add(apartmentToAdd);
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GetApartment> GetAll()
        {
            return _mapper.Map<List<GetApartment>>(_apartmentDas.GetAll());
        }

        public Apartment GetById(int id)
        {
            var apartment = _apartmentDas.GetById(id);
            if(apartment == null)
            {
                throw new ArgumentException($"No apartment found with such Id {id}");
            }

            return apartment;
        }

        public GetApartment Update(int id, PutApartment objectValue)
        {
            var apartment = new Apartment
            {
                Id = id,
                Name = objectValue.Name,
            };

            _apartmentDas.Update(apartment);
            return _mapper.Map<GetApartment>(apartment);
        }
    }
}
