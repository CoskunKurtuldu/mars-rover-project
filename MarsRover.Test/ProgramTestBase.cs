using MarsRover.Domain.Abstract;
using MarsRover.Domain.Model;
using MarsRover.Domain.Repository;
using MarsRover.Domain.Service;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MarsRover.Test
{
    public class ProgramTestBase
    {
        protected IServiceProvider Provider;
        protected MarsLandingService MarsLandingService;

        public ProgramTestBase()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IRepository, Repository>();
            serviceCollection.AddScoped(provider =>
                new MarsLandingService(
                    provider.GetRequiredService<IRepository>()
                    , 100
                    , new Plateau(
                        new Position(5, 5)
                        , 10))
                );

            var globalProvider = serviceCollection.BuildServiceProvider(true);
            var scope = globalProvider.CreateScope();
            Provider = scope.ServiceProvider;
            MarsLandingService = Provider.GetRequiredService<MarsLandingService>();
        }
    }
}

