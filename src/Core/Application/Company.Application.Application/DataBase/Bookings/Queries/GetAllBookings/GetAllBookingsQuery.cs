using Microsoft.EntityFrameworkCore;

namespace Company.Application.Application.DataBase.Bookings.Queries.GetAllBookings;

public class GetAllBookingsQuery : IGetAllBookingsQuery
{
    private readonly IDataBaseService _dataBaseService;

    public GetAllBookingsQuery(IDataBaseService dataBaseService)
    {
        _dataBaseService = dataBaseService;
    }
    
    public async Task<List<GetAllBookingsModel>> Execute()
    {
        var result = await (from booking in _dataBaseService.Booking 
            join customer in _dataBaseService.Customer 
                on booking.CustomerId equals customer.CustomerId
                select new GetAllBookingsModel()
            {
                BookingId = booking.BookingId,
                Code = booking.Code,
                RegisterDate = booking.RegisterDate,
                Type = booking.Type,
                CustomerFullname = customer.FullName,
                CustomerDocumentNumber = customer.DocumentNumber
            }).ToListAsync();
        return result;
    }
}