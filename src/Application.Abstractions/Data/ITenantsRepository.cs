using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Common.Dto.Tenants;

namespace Application.Abstractions.Data
{
    public interface ITenantsRepository
    {
        Task<IEnumerable<TenantDto>> Get();
        Task<TenantDto> Get(Guid id);
        Task<TenantDto> Create(CreateTenantDto createTenantDto);
        Task<int> Update(UpdateTenantDto createTenantDto);
        Task<int> Delete(DeleteTenantDto createTenantDto);
    }
}