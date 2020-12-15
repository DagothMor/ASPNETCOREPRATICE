using ASPNETHomework.Models.DTO;
using ASPNETHomework.Models.Requests.OrderFolder;
using ASPNETHomework.Models.Response.OrderFolder;
using AutoMapper;

namespace ASPNETHomework.Controllers.Mappings
{
	/// <summary>
	/// Mapping for requests and responds order entity controller.
	/// </summary>
	public class OrderProfile : Profile
	{
		/// <summary>
		/// initialize an instance <inheritdoc cref="OrderProfile"/>
		/// </summary>
		public OrderProfile()
		{
			CreateMap<CreateOrderRequest, OrderDto>();
			CreateMap<UpdateOrderRequest, OrderDto>();
			CreateMap<OrderDto, OrderResponse>();
		}
	}
}
