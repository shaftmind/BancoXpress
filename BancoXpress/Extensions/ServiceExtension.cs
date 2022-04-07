using BancoXpress.Application.AutoMapper;
using BancoXpress.Infra.CrossCutting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BancoXpress.Extensions
{
    public static class ServiceExtension
    {
        public static void AddDependencyInjection(this IServiceCollection services, IConfiguration config)
        {
            ContainerIoC.RegisterContainerIoC(services);
        }

        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
