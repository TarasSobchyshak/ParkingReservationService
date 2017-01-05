using AutoMapper;
using PRS.Business.Models;
using PRS.DAL.Entities;

namespace PRS.Business.Infrastructure.ProfileMappers
{
    public class OrganizationProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Organization, OrganizationModel>();

            CreateMap<OrganizationModel, Organization>()
                .ForMember(d => d.Parkings, opt => opt.Ignore());
        }
    }
}
