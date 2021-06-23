using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Infrastructure.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;

namespace Infrastructure.IoC.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            const string pattern = "*infrastructure*.dll";

            var infrastructureAssemblies = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, pattern)
                .Select(Assembly.LoadFile);
            
            services.Scan(scan =>
            {
                scan
                    .FromAssemblies(infrastructureAssemblies).AddClasses().UsingRegistrationStrategy(RegistrationStrategy.Skip).AsImplementedInterfaces().WithScopedLifetime()
                    .FromAssemblies(infrastructureAssemblies).AddClasses().UsingRegistrationStrategy(RegistrationStrategy.Skip).AsSelf().WithScopedLifetime();
            });

            var infrastucture = services.BuildServiceProvider().GetService<IInfrastructure>();
            infrastucture.Setup();
        }
    }
}