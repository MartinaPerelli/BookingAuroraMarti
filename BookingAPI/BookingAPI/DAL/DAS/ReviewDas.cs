using BookingAPI.DAL.DAS.Context;
using BookingAPI.DAL.DAS.Interfaces;
using BookingAPI.Models.ReviewModels;
using Microsoft.EntityFrameworkCore;

namespace BookingAPI.DAL.DAS
{
    public class ReviewDas : IReviewDas
    {
        private readonly BookingAMContext _ctx;

        public ReviewDas(BookingAMContext ctx)
        {
            _ctx = ctx;
        }

        public Review Create(Review review)
        {
           _ctx.Reviews.Add(review);
            _ctx.SaveChanges();
            return _ctx.Reviews.Include(r => r.Customer).Single(r => r.Id == review.Id);
        }

        public Review Update(Review review)
        {
            throw new NotImplementedException();
        }
    }
}
