using BookingAPI.Models.ReviewModels;
using BookingAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookingAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewsController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] PostReview review)
        {
            var reviewAdded = _reviewService.Create(review);
            return Created($"reviews/{reviewAdded.Id}",reviewAdded);
        }
    }
}
