namespace Company.Application.Application.DataBase.Customer.Queries.GetCustomerByDocumentNumber;

public interface IGetCustomerByDocumentNumberQuery
{
    Task<GetCustomerByDocumentNumberModel> Execute(string documentNumber);
}