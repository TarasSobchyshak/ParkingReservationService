using AutoMapper;
using PRS.Business.Models;
using PRS.DAL.Entities;

namespace PRS.Business.Infrastructure.ProfileMappers
{
    public class ParkingSpotProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<ParkingSpot, ParkingSpotModel>();

            CreateMap<ParkingSpotModel, ParkingSpot>()
                .ForMember(dest => dest.ParkingId, opt => opt.MapFrom(src => src.Parking.Id))
                .ForMember(dest => dest.Reservations, opt => opt.Ignore());
        }
    }
}
