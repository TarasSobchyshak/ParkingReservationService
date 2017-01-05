using AutoMapper;
using PRS.Business.Models;
using PRS.DAL.Entities;

namespace PRS.Business.Infrastructure.ProfileMappers
{
    public class ReservationProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Reservation, ReservationModel>();

            CreateMap<ReservationModel, Reservation>()
                .ForMember(dest => dest.ParkingId, opt => opt.MapFrom(src => src.Parking.Id))
                .ForMember(dest => dest.ParkingSpotId, opt => opt.MapFrom(src => src.ParkingSpot.Id))
                .ForMember(dest => dest.TransactionId, opt => opt.MapFrom(src => src.Transaction.Id));
        }
    }
}
