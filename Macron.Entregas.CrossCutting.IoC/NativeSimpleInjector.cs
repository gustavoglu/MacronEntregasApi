using AutoMapper;
using Macron.Entregas.Application.Interfaces;
using Macron.Entregas.Application.Services;
using Macron.Entregas.CrossCutting.Bus;
using Macron.Entregas.Domain.Commands;
using Macron.Entregas.Domain.Core.Bus;
using Macron.Entregas.Domain.Core.Events;
using Macron.Entregas.Domain.Core.Notifications;
using Macron.Entregas.Domain.Events;
using Macron.Entregas.Domain.Interfaces.EntityRepository;
using Macron.Entregas.Domain.Models.Entregas.Commands;
using Macron.Entregas.Domain.Models.Entregas.Events;
using Macron.Entregas.Infra.Data.Context;
using Macron.Entregas.Infra.Data.Repository.RepositoryEntitys;
using Microsoft.Extensions.DependencyInjection;

namespace Macron.Entregas.CrossCutting.IoC
{
    public class NativeSimpleInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {

            // Application
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            services.AddScoped<IEntregaAppService, EntregaAppService>();

            // Domain - Events
            services.AddScoped<IDomainNotificationHandler<DomainNotification>, DomainNotificationHandler>();
            services.AddScoped<IHandler<CriarEntregaEvent>, EntregaEventHandler>();
            services.AddScoped<IHandler<AtualizarEntregaEvent>, EntregaEventHandler>();
            services.AddScoped<IHandler<DeletarEntregaEvent>, EntregaEventHandler>();
            services.AddScoped<IHandler<ReativarEntregaEvent>, EntregaEventHandler>();

            // Domain - Commands
            services.AddScoped<IHandler<CriarEntregaCommand>, EntregaCommandHandler>();
            services.AddScoped<IHandler<AtualizarEntregaCommand>, EntregaCommandHandler>();
            services.AddScoped<IHandler<DeletarEntregaCommand>, EntregaCommandHandler>();
            services.AddScoped<IHandler<ReativarEntregaCommand>, EntregaCommandHandler>();

            // Infra - Data
            services.AddScoped<IEntregaRepository, EntregaRepository>();
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<EntregasContext>();

            // Infra - Bus
            services.AddScoped<IBus, InMemoryBus>();

        }
    }
}
