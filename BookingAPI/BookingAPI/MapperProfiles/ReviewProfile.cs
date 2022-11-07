using AutoMapper;
using BookingAPI.Models.ReviewModels;

namespace BookingAPI.MapperProfiles
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<PostReview, Review>().ReverseMap();
            CreateMap<PutReview, Review>().ReverseMap();
            CreateMap<GetReview, Review>().ReverseMap();
        }
    }
}
