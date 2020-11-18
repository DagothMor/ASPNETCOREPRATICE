using System;
using System.Collections.Generic;
using System.Text;
using ASPNETCOREHomework.Database.Domain;
using ASPNETHomework.Models.DTO;
using AutoMapper;


namespace ASPNETHomework.Services.Mappings
{
	/// <summary>
	/// Mapping profile "Notebook"
	/// </summary>
	public class NotebookProfile : Profile
	{
		/// <summary>
		/// Initializes an instant  <see cref="NotebookProfile"/>
		/// </summary>
		public NotebookProfile()
		{
			CreateMap<Notebook, NotebookDto>();
		}
	}
}
