using Company.Application.Application.DataBase;
using Company.Application.Domain.Entities.Booking;
using Company.Application.Domain.Entities.Customer;
using Company.Application.Domain.Entities.User;
using Company.Application.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
namespace Company.Application.Persistence.DataBase 
{
	public class DataBaseService: DbContext, IDataBaseService
	{
		public DataBaseService(DbContextOptions options) : base(options)
		{
			
		}
		
		public DbSet<UserEntity> User { get; set; }
		public DbSet<CustomerEntity> Customer { get; set; }
		public DbSet<BookingEntity> Booking { get; set; }
		
		public async Task<bool> SaveAsync()
		{
			return await SaveChangesAsync() > 0;
		}
		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			EntityConfiguration(modelBuilder);
		}
		
		private void EntityConfiguration(ModelBuilder modelBuilder)
		{
			new UserConfiguration(modelBuilder.Entity<UserEntity>());
			new CustomerConfiguration(modelBuilder.Entity<CustomerEntity>());
			new BookingConfiguration(modelBuilder.Entity<BookingEntity>());
		}

	}
}
