using System;

namespace Domain.Common.Entities.Tenants
{
    public class Tenant
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}