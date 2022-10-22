using CalculaJuros.Core.Tests;
using CalculaJuros.Web.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CalculaJuros.Web
{
    public class BaseWebUnitTest : BaseUnitTest
    {

        protected readonly IServiceCollection services;
        protected readonly IServiceProvider serviceProvider;

        public BaseWebUnitTest()
        {
            services = new ServiceCollection();
            services.AddTransient<ICalculadoraHttpService, CalculadoraHttpService>();
            serviceProvider = services.BuildServiceProvider();
        }

    }
}
