namespace Company.Application.Application.DataBase.User.Commands.CreateUser;

public interface ICreateUserCommand
{
    Task<CreateUserModel> Execute(CreateUserModel model);
}