using BancoXpress.Application.Services;
using BancoXpress.Application.Services.Client;
using BancoXpress.Application.Services.Transaction;
using BancoXpress.Domain.Entities.Client;
using BancoXpress.Domain.Interfaces.Base;
using BancoXpress.Domain.Interfaces.Client;
using BancoXpress.Infra.Data.Repositories;
using BancoXpress.Infra.Data.Scripts;
using Microsoft.Extensions.DependencyInjection;

namespace BancoXpress.Infra.CrossCutting
{
    public static class ContainerIoC
    {
        public static void RegisterContainerIoC(IServiceCollection services)
        {
            RegisterServices(services);
            RegisterQuerys(services);
            //RegisterRepositories(services);
        }

        private static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IClientService,ClientService>();
            services.AddTransient<ITransactionService, TransactionService>();
        }

        private static void RegisterQuerys(IServiceCollection services)
        {
            services.AddTransient<IClientQuery, ClientQuery>();
            services.AddTransient<IClientCommand, ClientCommand>();


        }

        //private static void RegisterRepositories(IServiceCollection services)
        //{
        //    services.AddScoped<IRepository<ClientEntity>, Repository<ClientEntity>>();
        //}
    }
}
