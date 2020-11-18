using System;
using System.Collections.Generic;
using System.Text;
using ASPNETCOREHomework.Database.Domain;
using ASPNETHomework.Models.DTO;

namespace ASPNETHomework.Services.Interfaces
{
	/// <summary>
	/// Service interface for working with "Notebook" data.
	/// </summary>
	public interface INotebookService
	{
		IEnumerable<NotebookDto> Get();
	}
}
