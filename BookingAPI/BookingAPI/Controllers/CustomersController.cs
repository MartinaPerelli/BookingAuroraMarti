using BookingAPI.Models.CustomerModels;
using BookingAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookingAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public IActionResult CreateCustomer([FromBody] PostCustomer postCustomer)
        {
            var customerToAdd = _customerService.Create(postCustomer);
            return CreatedAtAction(nameof(GetCustomerById),new { id = customerToAdd.Id }, customerToAdd);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var customers = _customerService.GetAll();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomerById(int id)
        {
            try
            {
                var customerOnId = _customerService.GetById(id);
                return Ok(customerOnId);
            }
            catch(ArgumentException exc)
            {
                return BadRequest(exc.Message);
            }
        }
    }
}
