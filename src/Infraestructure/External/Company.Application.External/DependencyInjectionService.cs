using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
namespace Company.Application.External 
{
	public static class DependencyInjectionService 
	{
		public static IServiceCollection AddExternal (this IServiceCollection services, IConfiguration configuration) 
		{
			return services; 
		}
	}
}
