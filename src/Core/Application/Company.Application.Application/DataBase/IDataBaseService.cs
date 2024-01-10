using Company.Application.Domain.Entities.Booking;
using Company.Application.Domain.Entities.Customer;
using Company.Application.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace Company.Application.Application.DataBase;

public interface IDataBaseService
{
    DbSet<UserEntity> User { get; set; }
    DbSet<CustomerEntity> Customer { get; set; }
    DbSet<BookingEntity> Booking { get; set; }
    Task<bool> SaveAsync();
}