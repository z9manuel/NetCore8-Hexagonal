namespace Company.Application.Application.DataBase.Bookings.Queries.GetBookingsByType;

public interface IGetBookingsByTypeQuery
{
    Task<List<GetBookingsByTypeModel>> Execute(string type);
}