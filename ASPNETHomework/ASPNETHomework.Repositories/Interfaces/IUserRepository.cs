using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Repositories.Interfaces.CRUD;

namespace ASPNETHomework.Repositories.Interfaces
{
	interface IUserRepository: ICrudRepository<UserDto, User>
	{
	}
}
