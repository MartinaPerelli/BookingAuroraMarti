using BookingAPI.Models.ApartmentModels;
using BookingAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookingAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApartmentsController : ControllerBase
    {
        private readonly IApartmentService _apartmentService;

        public ApartmentsController(IApartmentService apartmentService)
        {
            _apartmentService = apartmentService;   
        }

        [HttpPost]
        public IActionResult Create([FromBody] PostApartment apartment)
        {
            var apartmentToAdd = _apartmentService.Create(apartment);
            return CreatedAtAction(nameof(GetById), new { id = apartmentToAdd.Id }, apartmentToAdd);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var apartment = _apartmentService.GetById(id);
                return Ok(apartment);
            }
            catch(ArgumentException exc)
            {
                return BadRequest(exc.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_apartmentService.GetAll());
        }
    }
}
