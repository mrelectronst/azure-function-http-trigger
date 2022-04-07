using AzureFunctionSQLServer.Core;
using AzureFunctionSQLServer.Infrastructure;
using AzureFunctionSQLServer.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

[assembly: FunctionsStartup(typeof(AzureFunctionSQLServer.Startup))]

namespace AzureFunctionSQLServer
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<IWalletRepository, WalletRepository>();

            var connectionString = Environment.GetEnvironmentVariable("AzureSqlServerConnectionString");

            builder.Services.AddDbContext<FuncDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }
    }
}
