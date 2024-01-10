namespace Company.Application.Application.DataBase.User.Queries.GetUserById;

public interface IGetUserByIdQuery
{
    Task<GetUserByIdModel> Execute(int userId);
}