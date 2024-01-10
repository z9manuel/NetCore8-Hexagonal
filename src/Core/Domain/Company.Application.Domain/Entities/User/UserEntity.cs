using Company.Application.Domain.Entities.Booking;

namespace Company.Application.Domain.Entities.User;

public class UserEntity
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public ICollection<BookingEntity> Bookings { get; set; }
}