using AutoMapper;
using Company.Application.Application.Configuration;
using Company.Application.Application.DataBase.Bookings.Commands.CreateBooking;
using Company.Application.Application.DataBase.Bookings.Queries.GetAllBookings;
using Company.Application.Application.DataBase.Bookings.Queries.GetBookingsByDocumentNumber;
using Company.Application.Application.DataBase.Bookings.Queries.GetBookingsByType;
using Company.Application.Application.DataBase.Customer.Commands.CreateCustomer;
using Company.Application.Application.DataBase.Customer.Commands.DeleteCustomer;
using Company.Application.Application.DataBase.Customer.Commands.UpdateCustomer;
using Company.Application.Application.DataBase.Customer.Queries.GetAllCustomers;
using Company.Application.Application.DataBase.Customer.Queries.GetCustomerByDocumentNumber;
using Company.Application.Application.DataBase.Customer.Queries.GetCustomerById;
using Company.Application.Application.DataBase.User.Commands.CreateUser;
using Company.Application.Application.DataBase.User.Commands.DeleteUser;
using Company.Application.Application.DataBase.User.Commands.UpdateUser;
using Company.Application.Application.DataBase.User.Commands.UpdateUserPassword;
using Company.Application.Application.DataBase.User.Queries.GetAllUser;
using Company.Application.Application.DataBase.User.Queries.GetUserById;
using Company.Application.Application.DataBase.User.Queries.GetUserByUserNamePassword;
using Microsoft.Extensions.DependencyInjection;

namespace Company.Application.Application 
{
	public static class DependencyInjectionService 
	{
		public static IServiceCollection AddApplication (this IServiceCollection services) 
		{
			var mapper = new MapperConfiguration(config => 
			{
				config.AddProfile(new MapperProfile());
			});

			#region User Commands and Queries
			services.AddSingleton(mapper.CreateMapper());
			services.AddTransient<ICreateUserCommand, CreateUserCommand>();
			services.AddTransient<IUpdateUserCommand, UpdateUserCommand>();
			services.AddTransient<IDeleteUserCommand, DeleteUserCommand>();
			services.AddTransient<IUpdateUserPasswordCommand, UpdateUserPasswordCommand>();
			
			services.AddTransient<IGetAllUserQuery, GetAllUserQuery>();
			services.AddTransient<IGetUserByIdQuery, GetUserByIdQuery>();
			services.AddTransient<IGetUserByUserNamePasswordQuery, GetUserByUserNamePasswordQuery>();
			#endregion
			
			#region Customer Commands and Queries
			services.AddTransient<ICreateCustomerCommand, CreateCustomerCommand>();
			services.AddTransient<IUpdateCustomerCommand, UpdateCustomerCommand>();
			services.AddTransient<IDeleteCustomerCommand, DeleteCustomerCommand>();
			
			services.AddTransient<IGetAllCustomersQuery, GetAllCustomersQuery>();
			services.AddTransient<IGetCustomerByIdQuery, GetCustomerByIdQuery>();
			services.AddTransient<IGetCustomerByDocumentNumberQuery, GetCustomerByDocumentNumberQuery>();
			#endregion

			#region Booking 
			services.AddTransient<ICreateBookingCommand, CreateBookingCommand>();
			services.AddTransient<IGetAllBookingsQuery, GetAllBookingsQuery > ();
			services.AddTransient<IGetBookingsByDocumentNumberQuery, GetBookingsByDocumentNumberQuery > ();
			services.AddTransient<IGetBookingsByTypeQuery, GetBookingsByTypeQuery > ();
			#endregion
			
			
			return services; 
		}
	}
}
