using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Domain;
using AutoMapper;
using ASPNETHomework.Models.DTO;

namespace ASPNETHomework.Services.Mappings
{
	/// <summary>
	/// Mapping profile "Notebook"
	/// </summary>
	public class OrderProfile : Profile
	{
		/// <summary>
		/// Initializes an instant  <see cref="OrderProfile"/>
		/// </summary>
		public OrderProfile()
		{
			CreateMap<Order,OrderDto>().ReverseMap();
		}
	}
}
