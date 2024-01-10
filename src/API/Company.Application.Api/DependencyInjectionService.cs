using Microsoft.Extensions.DependencyInjection;
namespace Company.Application.Api 
{
	public static class DependencyInjectionService 
	{
		public static IServiceCollection AddWebApi (this IServiceCollection services) 
		{
			return services; 
		}
	}
}
