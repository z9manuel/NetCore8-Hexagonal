using Company.Application.Domain.Entities.Customer;

namespace Company.Application.Application.DataBase.Customer.Commands.CreateCustomer;

public interface ICreateCustomerCommand
{
    Task<CreateCustomerModel> Execute(CreateCustomerModel model);
}