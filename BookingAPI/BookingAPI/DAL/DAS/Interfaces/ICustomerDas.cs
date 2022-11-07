using BookingAPI.Models.CustomerModels;

namespace BookingAPI.DAL.DAS.Interfaces
{
    public interface ICustomerDas
    {
        public Customer Add(Customer customer);
        public Customer GetById(int idCustomer);

        public IEnumerable<Customer> GetAll();

    }
}
