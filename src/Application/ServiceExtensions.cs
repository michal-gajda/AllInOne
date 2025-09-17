namespace AllInOne.Application
{
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceExtensions
    {
        private const string LICENSE_KEY = "eyJhbGciOiJSUzI1NiIsImtpZCI6Ikx1Y2t5UGVubnlTb2Z0d2FyZUxpY2Vuc2VLZXkvYmJiMTNhY2I1OTkwNGQ4OWI0Y2IxYzg1ZjA4OGNjZjkiLCJ0eXAiOiJKV1QifQ.eyJpc3MiOiJodHRwczovL2x1Y2t5cGVubnlzb2Z0d2FyZS5jb20iLCJhdWQiOiJMdWNreVBlbm55U29mdHdhcmUiLCJleHAiOiIxNzgzMTIzMjAwIiwiaWF0IjoiMTc1MTYzNTYwNiIsImFjY291bnRfaWQiOiIwMTk3ZDU5ODFlODA3ZDBiYjZmOGFiZmNlYzY3ZWEwMyIsImN1c3RvbWVyX2lkIjoiY3RtXzAxanphc215ZnJ4cjY2d3lhMDZkZjdocGsyIiwic3ViX2lkIjoic3ViXzAxanphc3dmMjhjaDE0eGZ0amRnNzFxeW1zIiwiZWRpdGlvbiI6IjAiLCJ0eXBlIjoiMiJ9.zirt_P2YajYFv16njddthTrRhRnCmK8NLd1TT4cdf1Hohvg-HBdSp-3yEPyNTtPTvcMDN8TFpRpEVavvdWeKEZ183NENayBvvMFtpFKlbkt--Ok91BAc_LOuDca-W_rO4PBmONNGsOQiBMCxFtRDPE5ENJvvciZr1e8OmyFaurpC_OOCkeihWw5ImKh8rj55VgllJFpyrT_xIhe2OS7gg9RPUFdE0hjpROoE1ZivNvYzQFTiHw5sYvi1Vqg_tiN7kKQJR0aL_AoMhIJcXrTbv2GBmSk3eTI7XVI5SWZqbSyJM2O33T9tiMvfvy3ixdW5YOXkjqztTohXxCXNIScOfA";

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            services.AddMediatR(cfg =>
            {
                cfg.LicenseKey = LICENSE_KEY;
                cfg.RegisterServicesFromAssembly(assembly);
            });

            return services;
        }
    }
}
