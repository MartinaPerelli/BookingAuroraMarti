using BookingAPI.Models.ReviewModels;

namespace BookingAPI.Services.Interfaces
{
    public interface IReviewService
    {
        public Review Create(PostReview postReview);
        public GetReview Update(PutReview putReview);
    }
}
