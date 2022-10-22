using CalculaJuros.Core.Domains;
using CalculaJuros.Core.Tests;
using Microsoft.Extensions.DependencyInjection;

namespace CalculaJuros.Core
{
    public class BaseCoreUnitTest: BaseUnitTest
    {

        protected readonly IServiceCollection services;
        protected readonly IServiceProvider serviceProvider;

        public BaseCoreUnitTest()
        {
            services = new ServiceCollection();
            services.AddTransient<ICalculadoraService, CalculadoraService>();
            serviceProvider = services.BuildServiceProvider();
        }

    }
}
