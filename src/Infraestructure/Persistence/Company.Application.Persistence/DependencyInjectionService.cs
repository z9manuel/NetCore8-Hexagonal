using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Company.Application.Application.DataBase;
using Company.Application.Persistence.DataBase;
namespace Company.Application.Persistence 
{
	public static class DependencyInjectionService 
	{
		public static IServiceCollection AddPersistence (this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<DataBaseService>(options =>
				options.UseSqlServer(configuration["SQLConnection"]));
			services.AddScoped<IDataBaseService, DataBaseService>();
			return services;

		}
	}
}
