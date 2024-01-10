using AutoMapper;
using Company.Application.Application.DataBase.Bookings.Commands.CreateBooking;
using Company.Application.Application.DataBase.Customer.Commands.CreateCustomer;
using Company.Application.Application.DataBase.Customer.Commands.UpdateCustomer;
using Company.Application.Application.DataBase.Customer.Queries.GetAllCustomers;
using Company.Application.Application.DataBase.Customer.Queries.GetCustomerByDocumentNumber;
using Company.Application.Application.DataBase.Customer.Queries.GetCustomerById;
using Company.Application.Application.DataBase.User.Commands.CreateUser;
using Company.Application.Application.DataBase.User.Commands.UpdateUser;
using Company.Application.Application.DataBase.User.Queries.GetAllUser;
using Company.Application.Application.DataBase.User.Queries.GetUserById;
using Company.Application.Application.DataBase.User.Queries.GetUserByUserNamePassword;
using Company.Application.Domain.Entities.Booking;
using Company.Application.Domain.Entities.Customer;
using Company.Application.Domain.Entities.User;

namespace Company.Application.Application.Configuration;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        #region User
        CreateMap<UserEntity, CreateUserModel>().ReverseMap();
        CreateMap<UserEntity, UpdateUserModel>().ReverseMap();
        CreateMap<UserEntity, GetAllUserModel>().ReverseMap();
        CreateMap<UserEntity, GetUserByIdModel>().ReverseMap();
        CreateMap<UserEntity, GetUserByUserNamePasswordModel>().ReverseMap();
        #endregion

        #region Customer
        CreateMap<CustomerEntity, CreateCustomerModel>().ReverseMap();
        CreateMap<CustomerEntity, UpdateCustomerModel>().ReverseMap();
        CreateMap<CustomerEntity, GetAllCustomersModel>().ReverseMap();
        CreateMap<CustomerEntity, GetCustomerByIdModel>().ReverseMap();
        CreateMap<CustomerEntity, GetCustomerByDocumentNumberModel>().ReverseMap();
        #endregion
        
        #region Booking
        CreateMap<BookingEntity, CreateBookingModel>().ReverseMap();
        #endregion

    }
}