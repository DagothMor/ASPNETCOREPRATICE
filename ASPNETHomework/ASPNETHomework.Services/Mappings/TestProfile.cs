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
	public class TestProfile : Profile
	{
		/// <summary>
		/// Initializes an instant  <see cref="TestProfile"/>
		/// </summary>
		public TestProfile()
		{
			CreateMap<Order,OrderDto>().ReverseMap();
		}
	}
}
