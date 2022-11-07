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
            var customerToAdd = _ctx.Customers.Add(customer);
            _ctx.SaveChanges();
            return customerToAdd.Entity;
        }

        public IEnumerable<Customer> GetAll()
        {
            var customers = _ctx.Customers;
            return customers;
        }

        public Customer? GetById(int idCustomer)
        {
            var customer = _ctx.Customers.SingleOrDefault(customer => customer.Id == idCustomer);
            return customer;
        }
    }
}
