using AutoMapper;
using Domain.Models;
using Domain.ViewModels.Tenants;

namespace Application.Mappings
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Domain.Common.Entities.Tenants.Tenant, Tenant>();
            CreateMap<Tenant, TenantVm>();
        }
    }
}