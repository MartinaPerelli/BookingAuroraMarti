using BookingAPI.Models.ReviewModels;

namespace BookingAPI.DAL.DAS.Interfaces
{
    public interface IReviewDas 
    {
        public Review Create(Review review);
        public Review Update(Review review);

    }
}
