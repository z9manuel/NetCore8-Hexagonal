namespace Company.Application.Application.DataBase.User.Commands.DeleteUser;

public interface IDeleteUserCommand
{
    Task<bool> Execute(int userId);
}