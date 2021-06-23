using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using Domain.Common.Dto.Tenants;
using Domain.Models;
using Domain.ViewModels.Tenants;

namespace Application.Mappings
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<TenantDto, Tenant>();
            CreateMap<Tenant, TenantVm>();
        }
    }
}