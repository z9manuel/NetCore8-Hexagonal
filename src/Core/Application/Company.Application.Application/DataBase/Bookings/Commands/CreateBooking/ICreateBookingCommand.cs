namespace Company.Application.Application.DataBase.Bookings.Commands.CreateBooking;

public interface ICreateBookingCommand
{
    Task<CreateBookingModel> Execute(CreateBookingModel model);
}