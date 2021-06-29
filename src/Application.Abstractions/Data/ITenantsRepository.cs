using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Common.Dto.Tenants;
using Domain.Common.Entities.Tenants;

namespace Application.Abstractions.Data
{
    public interface ITenantsRepository
    {
        Task<IEnumerable<Tenant>> Get();
        Task<Tenant> Get(Guid id);
        Task<Tenant> Create(CreateTenantDto createTenantDto);
        Task<int> Update(UpdateTenantDto createTenantDto);
        Task<int> Delete(DeleteTenantDto createTenantDto);
    }
}