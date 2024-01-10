using Microsoft.Extensions.DependencyInjection;
namespace Company.Application.Common 
{
	public static class DependencyInjectionService 
	{
		public static IServiceCollection AddCommon (this IServiceCollection services) 
		{
			return services; 
		}
	}
}
