using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using AutoMapper;

namespace ASPNETHomework.Repositories.Mappings
{
	/// <summary>
	/// Mapping profile.
	/// </summary>
	public class CustomerProfile : Profile
	{
		/// <summary>
		/// Initialize an instance <see cref="CustomerProfile"/>
		/// </summary>
		public CustomerProfile()
		{
			CreateMap<Customer, CustomerDto>().ReverseMap();
		}
	}
}
