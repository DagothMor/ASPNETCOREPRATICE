using System;
using System.Collections.Generic;
using System.Text;
using ASPNETCOREHomework.Database.Domain;
using ASPNETHomework.Models.DTO;

namespace ASPNETHomework.Services.Interfaces
{
	public interface INotebookService
	{
		IEnumerable<NotebookDto> Get();
	}
}
