using Company.Application.Domain.Entities.User;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company.Application.Persistence.Configuration;

public class UserConfiguration
{
    public UserConfiguration(EntityTypeBuilder<UserEntity> entityBuilder)
    {
        entityBuilder.HasKey(x => x.UserId);
        entityBuilder.Property(x => x.FirstName).IsRequired();
        entityBuilder.Property(x => x.LastName).IsRequired();
        entityBuilder.Property(x => x.UserName).IsRequired();
        entityBuilder.Property(x => x.Password).IsRequired();
        
        entityBuilder.HasMany(x => x.Bookings)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.UserId);
    }
}