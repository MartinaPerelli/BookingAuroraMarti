using BookingAPI.Models.CustomerModels;

namespace BookingAPI.Services.Interfaces
{
    public interface ICustomerService : IServiceCrud<Customer,PostCustomer,GetCustomer,PutCustomer>
    {
    }
}
