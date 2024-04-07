
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Keystone.Extensions;

public static class ApiBehaviorExtensions
{
    public static void ConfigureApiBehavior(this IServiceCollection services)
    {
        services.Configure<ApiBehaviorOptions>(options =>
        {
            options.SuppressModelStateInvalidFilter = true;
        });
        
        
    }
}