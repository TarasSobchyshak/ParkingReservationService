using AutoMapper;
using PRS.Business.Models;
using PRS.DAL.Entities;

namespace PRS.Business.Infrastructure.ProfileMappers
{
    public class ParkingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Parking, ParkingModel>();

            CreateMap<ParkingModel, Parking>()
                .ForMember(dest => dest.OrganizationId, opt => opt.MapFrom(src => src.Organization.Id))
                .ForMember(dest => dest.ParkingSpots, opt => opt.Ignore());
        }
    }
}
