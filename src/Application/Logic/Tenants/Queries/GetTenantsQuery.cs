using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Abstractions.Data;
using AutoMapper;
using Domain.Models;
using Domain.ViewModels.Tenants;
using MediatR;

namespace Application.Logic.Tenants.Queries
{
    public class GetTenantsQuery : IRequest<TenantsVm>
    {
        
    }

    public class GetTodosQueryHandler : IRequestHandler<GetTenantsQuery, TenantsVm>
    {
        private readonly ITenantsRepository _tenantsRepository;
        private readonly IMapper _mapper;
        
        public GetTodosQueryHandler(ITenantsRepository tenantsRepository, IMapper mapper)
        {
            _tenantsRepository = tenantsRepository;
            _mapper = mapper;
        }

        public async Task<TenantsVm> Handle(GetTenantsQuery request, CancellationToken cancellationToken)
        {
            var tenantsDto = await _tenantsRepository.Get();
            var tenants = _mapper.Map<IEnumerable<Tenant>>(tenantsDto);
            var tenantsVm = new TenantsVm
            {
                Tenants = _mapper.Map<IEnumerable<TenantVm>>(tenants)
            };
            
            return tenantsVm;
        }
    }
}