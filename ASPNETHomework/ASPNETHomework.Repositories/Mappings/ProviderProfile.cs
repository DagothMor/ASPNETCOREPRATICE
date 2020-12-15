using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using AutoMapper;

namespace ASPNETHomework.Repositories.Mappings
{
	/// <summary>
	/// Mapping for <see cref="Provider"/>.
	/// </summary>
	public class ProviderProfile : Profile
	{
		/// <summary>
		/// Initialize an instance <see cref="ProviderProfile"/>.
		/// </summary>
		public ProviderProfile()
		{
			CreateMap<Provider, ProviderDto>().ReverseMap();
		}
	}
}
