namespace Company.Application.Application.DataBase.Customer.Queries.GetAllCustomers;

public interface IGetAllCustomersQuery
{ 
    Task<List<GetAllCustomersModel>> Execute();
}