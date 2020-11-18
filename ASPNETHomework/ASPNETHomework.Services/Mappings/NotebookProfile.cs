using System;
using System.Collections.Generic;
using System.Text;
using ASPNETCOREHomework.Database.Domain;
using ASPNETHomework.Models.DTO;
using AutoMapper;


namespace ASPNETHomework.Services.Mappings
{
	public class NotebookProfile : Profile
	{
		public NotebookProfile()
		{
			CreateMap<Notebook, NotebookDto>();
		}
	}
}
