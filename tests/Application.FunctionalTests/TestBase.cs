namespace AllInOne.Application.FunctionalTests;

using System.Diagnostics;
using AllInOne.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public abstract class TestBase
{
    public TestContext TestContext { get; set; } = null!;

    protected ServiceProvider Provider { get; init; }

    public TestBase()
    {
        var services = new ServiceCollection();

        var collection = new Dictionary<string, string?>
        {
        };

        var file = Path.Combine(Environment.CurrentDirectory, "appsettings.json");
        File.AppendAllText(file, string.Empty);

        var configuration = new ConfigurationBuilder()
            .SetBasePath(Environment.CurrentDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
            .AddEnvironmentVariables("TEST_")
            .AddInMemoryCollection(collection)
            .Build();

        services.AddSingleton<IConfiguration>(configuration);
        services.AddLogging();

        services
            .AddApplication()
            .AddInfrastructure(configuration)
            ;

        services.AddSingleton(new ActivitySource(typeof(TestBase).FullName!));

        this.Provider = services.BuildServiceProvider();
    }
}
