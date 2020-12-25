using ASPNETHomework.Models.DTO;
using ASPNETHomework.Models.Requests.UserFolder;
using ASPNETHomework.Models.Response.UserFolder;
using AutoMapper;

namespace ASPNETHomework.Controllers.Mappings
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<CreateUserRequest, UserDto>();
			CreateMap<UpdateUserRequest, UserDto>();
			CreateMap<UserDto, UserResponse>();
		}
	}
}
