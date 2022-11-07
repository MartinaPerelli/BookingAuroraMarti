using BookingAPI.DAL.DAS.Context;
using BookingAPI.DAL.DAS.Interfaces;
using BookingAPI.Models.CustomerModels;

namespace BookingAPI.DAL.DAS
{
    public class CustomerDas : ICustomerDas
    {
        private readonly BookingAMContext _ctx;
        public CustomerDas(BookingAMContext ctx)
        {
            _ctx = ctx;
        }

        public Customer Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int idCustomer)
        {
            throw new NotImplementedException();
        }
    }
}
