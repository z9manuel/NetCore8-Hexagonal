using AutoMapper;
using Company.Application.Domain.Entities.Customer;

namespace Company.Application.Application.DataBase.Customer.Commands.UpdateCustomer;

public class UpdateCustomerCommand : IUpdateCustomerCommand
{
    private readonly IDataBaseService _dataBaseService;
    private readonly IMapper _mapper;

    public UpdateCustomerCommand(IDataBaseService dataBaseService, IMapper mapper)
    {
        _dataBaseService = dataBaseService;
        _mapper = mapper;
    }

    public async Task<UpdateCustomerModel> Exectute(UpdateCustomerModel model)
    {
        var entity = _mapper.Map<CustomerEntity>(model);
        _dataBaseService.Customer.Update(entity);
        await _dataBaseService.SaveAsync();
        return model;
    }
}