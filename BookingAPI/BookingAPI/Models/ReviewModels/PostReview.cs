namespace BookingAPI.Models.ReviewModels
{
    public class PostReview
    {
        public string Content { get; set; }

        public DateTime ReviewDate { get; set; }
        public int CustomerId { get; set; }
    }
}
