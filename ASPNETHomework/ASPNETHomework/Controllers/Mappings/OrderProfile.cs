using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Models.Requests.Order;
using ASPNETHomework.Models.Response.Order;
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
