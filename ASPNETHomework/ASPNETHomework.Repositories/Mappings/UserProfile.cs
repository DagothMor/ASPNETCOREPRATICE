using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using AutoMapper;

namespace ASPNETHomework.Repositories.Mappings
{
	/// <summary>
	/// Mapping profile.
	/// </summary>
	public class UserProfile : Profile
	{
		/// <summary>
		/// Initialize an instance <see cref="UserProfile"/>
		/// </summary>
		public UserProfile()
		{
			CreateMap<User, UserDto>().ReverseMap();
		}
	}
}
