using AutoMapper;
using PRS.Business.Models;
using PRS.DAL.Entities;

namespace PRS.Business.Infrastructure.ProfileMappers
{
    public class TransactionProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Transaction, TransactionModel>();

            CreateMap<TransactionModel, Transaction>()
                .ForMember(dest => dest.ReservationId, opt => opt.MapFrom(src => src.Reservation.Id))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.User.Id));
        }
    }
}
