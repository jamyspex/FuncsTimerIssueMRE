using Autofac.Extensions.DependencyInjection;
using Microsoft.Azure.Functions.Worker.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace FuncsTimerIssueMRE
{
    internal static class Program
    {
        #region Public Methods

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, builder) =>
                {
                    builder.AddJsonFile("appsettings.json", false, true);
                })
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureFunctionsWorker((_, workerApplicationBuilder) =>
                {
                    workerApplicationBuilder.UseFunctionExecutionMiddleware();
                });
        }

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        #endregion
    }
}
