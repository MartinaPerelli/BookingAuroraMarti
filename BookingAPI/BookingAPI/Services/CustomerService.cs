using AutoMapper;
using BookingAPI.DAL.DAS.Interfaces;
using BookingAPI.Models.CustomerModels;
using BookingAPI.Services.Interfaces;

namespace BookingAPI.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerDas _customerDas;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerDas customerDas, IMapper mapper)
        {
            _customerDas = customerDas;
            _mapper = mapper;
        }

        public Customer Create(PostCustomer objectValue)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GetCustomer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public GetCustomer Update(int id, PutCustomer objectValue)
        {
            throw new NotImplementedException();
        }
    }
}
