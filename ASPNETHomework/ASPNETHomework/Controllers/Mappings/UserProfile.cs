using ASPNETHomework.Models.DTO;
using ASPNETHomework.Models.Requests.UserFolder;
using ASPNETHomework.Models.Response.UserFolder;
using AutoMapper;

namespace ASPNETHomework.Controllers.Mappings
{
	/// <summary>
	/// Mapping for requests and responds User entity controller.
	/// </summary>
	public class UserProfile : Profile
	{
		/// <summary>
		/// initialize an instance <inheritdoc cref="UserProfile"/>
		/// </summary>
		public UserProfile()
		{
			CreateMap<CreateUserRequest, UserDto>();
			CreateMap<UpdateUserRequest, UserDto>();
			CreateMap<UserDto, UserResponse>();
		}
	}
}
