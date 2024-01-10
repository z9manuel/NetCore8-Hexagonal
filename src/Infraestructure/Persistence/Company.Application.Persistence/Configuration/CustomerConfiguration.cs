using Company.Application.Domain.Entities.Customer;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company.Application.Persistence.Configuration;

public class CustomerConfiguration
{
    public CustomerConfiguration(EntityTypeBuilder<CustomerEntity> entityBuilder)
    {
        entityBuilder.HasKey(x => x.CustomerId);
        entityBuilder.Property(x => x.FullName).IsRequired();
        entityBuilder.Property(x => x.DocumentNumber).IsRequired();
        
        entityBuilder.HasMany(x => x.Bookings)
            .WithOne(x => x.Customer)
            .HasForeignKey(x => x.UserId);
    }
}