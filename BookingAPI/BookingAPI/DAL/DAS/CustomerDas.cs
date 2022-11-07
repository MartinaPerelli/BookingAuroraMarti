using BookingAPI.DAL.DAS.Context;
using BookingAPI.DAL.DAS.Interfaces;
using BookingAPI.Models.CustomerModels;
using Microsoft.EntityFrameworkCore;

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

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            var customers = _ctx.Customers;
            return customers;
        }

        //public Task<IEnumerable<Customer>> GetAll()
        //{
        //    return (Task<IEnumerable<Customer>>)_ctx.Customers.AsAsyncEnumerable();
        //}

        public Customer? GetById(int idCustomer)
        {
            var customer = _ctx.Customers.SingleOrDefault(customer => customer.Id == idCustomer);
            return customer;
        }

        public Customer Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
