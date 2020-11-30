using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using AutoMapper;

namespace ASPNETHomework.Repositories.Mappings
{
	/// <summary>
	/// Профиль маппинга (одежда).
	/// </summary>
	public class TestProfile : Profile
	{
		/// <summary>
		/// Инициализирует экземпляр <see cref="DressProfile"/>
		/// </summary>
		public TestProfile()
		{
			CreateMap<Order, OrderDto>().ReverseMap();
		}
	}
}
