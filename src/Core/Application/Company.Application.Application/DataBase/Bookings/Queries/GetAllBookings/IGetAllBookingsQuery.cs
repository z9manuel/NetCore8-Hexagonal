namespace Company.Application.Application.DataBase.Bookings.Queries.GetAllBookings;

public interface IGetAllBookingsQuery
{
    Task<List<GetAllBookingsModel>> Execute();
}