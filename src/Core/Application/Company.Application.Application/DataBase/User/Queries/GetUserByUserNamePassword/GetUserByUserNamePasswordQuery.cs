using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Company.Application.Application.DataBase.User.Queries.GetUserByUserNamePassword;

public class GetUserByUserNamePasswordQuery : IGetUserByUserNamePasswordQuery
{
    private readonly IDataBaseService _dataBaseService;
    private readonly IMapper _mapper;

    public GetUserByUserNamePasswordQuery(IDataBaseService dataBaseService, IMapper mapper)
    {
        _dataBaseService = dataBaseService;
        _mapper = mapper;
    }
    
    public async Task<GetUserByUserNamePasswordModel> Execute(string userName, string password)
    {
        var entity = await _dataBaseService.User
            .FirstOrDefaultAsync(x=> x.UserName == userName && x.Password == password);
        return _mapper.Map<GetUserByUserNamePasswordModel>(entity);
    }
}