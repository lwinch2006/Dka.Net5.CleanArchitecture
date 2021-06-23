using System.Collections.Generic;

namespace Domain.ViewModels.Tenants
{
    public class TenantsVm
    {
        public IEnumerable<TenantVm> Tenants { get; set; }
    }
}