namespace Company.Application.Application.DataBase.Bookings.Queries.GetBookingsByDocumentNumber;

public interface IGetBookingsByDocumentNumberQuery
{
    Task<List<GetBookingsByDocumentNumberModel>> Execute(string documentNumber);
}