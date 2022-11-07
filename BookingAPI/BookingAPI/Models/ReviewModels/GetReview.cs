using BookingAPI.Models.CustomerModels;

namespace BookingAPI.Models.ReviewModels
{
    public class GetReview
    {
        public string Content { get; set; }
        public DateTime ReviewDate { get; set; }
        public Customer Customer { get; set; }
    }
}
