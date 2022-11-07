using BookingAPI.Models.CustomerModels;

namespace BookingAPI.Models.ReviewModels
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime ReviewDate { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
