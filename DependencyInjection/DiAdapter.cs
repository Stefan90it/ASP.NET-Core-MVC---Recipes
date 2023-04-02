using Microsoft.Extensions.DependencyInjection;
using NencysKitchenMVC.Services;
using NencysKitchenMVC.Services.Interfaces;
using System.Reflection;

namespace DependencyInjection
{
    public static class DiAdapter
    {
        public static void MyServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<IAuthService, AuthService>();
        }
    }
}
