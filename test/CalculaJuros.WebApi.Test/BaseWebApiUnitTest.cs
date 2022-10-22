using CalculaJuros.Application.Services;
using CalculaJuros.Core.Domains;
using CalculaJuros.Core.Tests;
using Microsoft.Extensions.DependencyInjection;

namespace CalculaJuros.WebApi
{
    public class BaseWebApiUnitTest : BaseUnitTest
    {
        protected readonly IServiceCollection services;
        protected readonly IServiceProvider serviceProvider;

        public BaseWebApiUnitTest()
        {
            services = new ServiceCollection();
            services.AddTransient<ICalculadoraService, CalculadoraService>();
            services.AddTransient<ICalculadoraFinanceiraService, CalculadoraFinanceiraService>();
            serviceProvider = services.BuildServiceProvider();
        }
    }
}