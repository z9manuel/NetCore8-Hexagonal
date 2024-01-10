namespace Company.Application.Application.DataBase.Customer.Queries.GetCustomerById;

public interface IGetCustomerByIdQuery
{
    Task<GetCustomerByIdModel> Execute(int customerId);
}