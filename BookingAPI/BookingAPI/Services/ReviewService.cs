using AutoMapper;
using BookingAPI.DAL.DAS.Interfaces;
using BookingAPI.Models.ReviewModels;
using BookingAPI.Services.Interfaces;

namespace BookingAPI.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewDas _reviewDas;
        private readonly IMapper _mapper;

        public ReviewService(IReviewDas reviewDas, IMapper mapper)
        {
            _reviewDas = reviewDas;
            _mapper = mapper;
        }

        public Review Create(PostReview postReview)
        {
            var reviewToAdd = _mapper.Map<Review>(postReview);  
            return _reviewDas.Create(reviewToAdd);
           
        }

        public GetReview Update(PutReview putReview)
        {
            throw new NotImplementedException();
        }
    }
}
