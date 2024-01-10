using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Company.Application.Application.DataBase.Customer.Queries.GetAllCustomers;

public class GetAllCustomersQuery : IGetAllCustomersQuery
{
    private readonly IDataBaseService _dataBaseService;
    private readonly IMapper _mapper;

    public GetAllCustomersQuery(IDataBaseService dataBaseService, IMapper mapper)
    {
        _dataBaseService = dataBaseService;
        _mapper = mapper;
    }
    
    public async Task<List<GetAllCustomersModel>> Execute()
    {
        var listEntities = await _dataBaseService.Customer.ToListAsync();
        return _mapper.Map<List<GetAllCustomersModel>>(listEntities);
    }
}