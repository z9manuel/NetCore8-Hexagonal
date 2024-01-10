namespace Company.Application.Application.DataBase.Bookings.Queries.GetAllBookings;

public class GetAllBookingsModel
{
    public int BookingId { get; set; }
    public DateTime RegisterDate { get; set; }
    public string Code { get; set; }
    public string Type { get; set; }
    public string CustomerFullname { get; set; }
    public string CustomerDocumentNumber { get; set; }
}