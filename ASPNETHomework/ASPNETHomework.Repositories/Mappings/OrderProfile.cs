using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using AutoMapper;

namespace ASPNETHomework.Repositories.Mappings
{
	/// <summary>
	/// Mapping profile.
	/// </summary>
	public class OrderProfile : Profile
	{
		/// <summary>
		/// Initialize an instance <see cref="OrderProfile"/>
		/// </summary>
		public OrderProfile()
		{
			CreateMap<Order, OrderDto>().ReverseMap();
		}
	}
}
