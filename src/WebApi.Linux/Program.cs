namespace AllInOne.WebApi;

using AllInOne.Application;
using AllInOne.Infrastructure;

public class Program
{
    private const int EXIT_SUCCESS = 0;

    public static async Task<int> Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddHealthChecks();

        builder.Services
            .AddApplication()
            .AddInfrastructure(builder.Configuration)
            ;

        builder.Services.AddControllers();
        builder.Services.AddOpenApi();

        var app = builder.Build();

        app.UseHealthChecks("/health");

        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseAuthorization();

        app.MapControllers();

        await app.RunAsync();

        return EXIT_SUCCESS;
    }
}
