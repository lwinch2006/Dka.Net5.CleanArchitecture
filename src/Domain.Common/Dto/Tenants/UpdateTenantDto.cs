using System;

namespace Domain.Common.Dto.Tenants
{
    public class UpdateTenantDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}