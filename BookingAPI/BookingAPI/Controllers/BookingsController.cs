using BookingAPI.Models.BookingModels;
using BookingAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookingAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var booking = _bookingService.GetById(id);
                return Ok(booking);
            }
            catch (ArgumentException exc)
            {
                return BadRequest(exc.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_bookingService.GetAll());
        }

        [HttpPost]
        public IActionResult Create([FromBody] PostBooking postBooking)
        {
            try
            {
               var booking= _bookingService.Create(postBooking);
                return CreatedAtAction(nameof(GetById),new { id = booking.Id },booking);
            }
            catch(ArgumentException exc)
            {
                return BadRequest(exc.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] PutBooking putBooking)
        {
            var booking = _bookingService.Update(id, putBooking);
            return Ok(booking);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookingService.DeleteById(id);
            return Ok();
        }
    }
}
