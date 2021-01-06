using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Repositories.Interfaces.CRUD;

namespace ASPNETHomework.Repositories.Interfaces
{
	/// <summary>
	/// User repository,implemented all CRUD operations.
	/// </summary>
	interface IUserRepository : ICrudRepository<UserDto, User>
	{
	}
}
