using CalculaJuros.Application.Services;
using CalculaJuros.Core.Domains;
using CalculaJuros.Core.Tests;
using Microsoft.Extensions.DependencyInjection;

namespace CalculaJuros.Application
{
    public class BaseApplicationUnitTest: BaseUnitTest
    {

        protected readonly IServiceCollection services;
        protected readonly IServiceProvider serviceProvider;

        public BaseApplicationUnitTest()
        {
            services = new ServiceCollection();
            services.AddTransient<ICalculadoraService, CalculadoraService>();
            services.AddTransient<ICalculadoraFinanceiraService, CalculadoraFinanceiraService>();
            serviceProvider = services.BuildServiceProvider();
        }

    }
}