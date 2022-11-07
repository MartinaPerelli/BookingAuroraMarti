using AutoMapper;
using BookingAPI.DAL.DAS;
using BookingAPI.DAL.DAS.Interfaces;
using BookingAPI.Models.CustomerModels;
using BookingAPI.Services.Interfaces;
using BookingAPI.Utilities;

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

        public Customer Create(PostCustomer customer)
        {
            if(!customer.FiscalCode.isFiscalCodeValid())
            {
                throw new ArgumentException("Invalid Fiscal Code");
            }
            var customerToAdd = _mapper.Map<Customer>(customer);
            return _customerDas.Add(customerToAdd);
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GetCustomer> GetAll()
        {
            var customers = _customerDas.GetAll();
            var customersToPresent = _mapper.Map<IEnumerable<GetCustomer>>(customers);
            return customersToPresent;
        }

        //public Task<IEnumerable<GetCustomer>> GetAll()
        //{
        //    var customers = _customerDas.GetAll();
        //    return _mapper.Map<Task<IEnumerable<GetCustomer>>>(customers);
        //}

        public Customer GetById(int id)
        {
           
            var customerOnId = _customerDas.GetById(id);
            if(customerOnId == null)
            {
                throw new ArgumentException($"No customer found with such id {id}");
            }
            return customerOnId;
        }

        public GetCustomer Update(int id, PutCustomer objectValue)
        {
            throw new NotImplementedException();
        }
    }
}
