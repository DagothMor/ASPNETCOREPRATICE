using ASPNETHomework.DAL.Contexts;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Repositories.Interfaces;
using AutoMapper;

namespace ASPNETHomework.Repositories.Repositories
{
	/// <summary>
	/// Repository for work with entity "User".
	/// </summary>
	public class UserRepository : BaseRepository<UserDto, User>, IUserRepository
	{
		/// <summary>
		/// initialize an instance <see cref="UserRepository"/>.
		/// </summary>
		/// <param name="context">Data context.</param>
		/// <param name="mapper">Mapper.</param>
		public UserRepository(AspNetHomeworkContext context, IMapper mapper) : base(context, mapper)
		{
		}
	}
}
