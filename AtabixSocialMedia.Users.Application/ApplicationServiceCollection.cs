using Microsoft.Extensions.DependencyInjection;

namespace AtabixSocialMedia.Users.Application
{
    public static class ApplicationServiceCollection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services) 
        { 
            return services;
        }
    }
}
