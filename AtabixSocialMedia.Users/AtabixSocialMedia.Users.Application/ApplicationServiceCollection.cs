using Microsoft.Extensions.DependencyInjection;

namespace AtabixSocialMedia.Users.Application
{
    public static class ApplicationServiceCollection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services) 
        {
            services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining(typeof(ApplicationServiceCollection)));

            return services;
        }
    }
}
