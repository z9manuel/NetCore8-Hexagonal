namespace Company.Application.Application.DataBase.User.Queries.GetAllUser;

public interface IGetAllUserQuery
{
    Task<List<GetAllUserModel>> Execute();
}