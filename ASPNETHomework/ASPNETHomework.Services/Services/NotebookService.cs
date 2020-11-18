using System;
using System.Collections.Generic;
using System.Text;
using ASPNETCOREHomework.Database.Domain;
using ASPNETCOREHomework.Database.Mocks;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Services.Interfaces;
using AutoMapper;

namespace ASPNETHomework.Services.Services
{
	/// <summary>
	/// Service for work with data of "Notebook"
	/// </summary>
	public class NotebookService:INotebookService
	{
		private readonly IMapper _mapper;

		public NotebookService(IMapper mapper)
		{
			_mapper = mapper;
		}
		/// <inheritdoc cref="INotebookService"/>
		public IEnumerable<NotebookDto> Get()
		{
			var notebooks = NotebookMock.GetNotebooks();
			var response = _mapper.Map<IEnumerable<NotebookDto>>(notebooks);
			return response;
		} 
	}
}
