namespace Company.Application.Application.DataBase.Customer.Commands.UpdateCustomer;

public interface IUpdateCustomerCommand
{
    Task<UpdateCustomerModel> Exectute(UpdateCustomerModel model);
}