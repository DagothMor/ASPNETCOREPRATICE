using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Services.Interfaces.CRUD;

namespace ASPNETHomework.Services.Interfaces
{
	/// <summary>
	/// Test service:create,full and add in database tables.
	/// </summary>
	public interface ITestService : ICrudRepository<OrderDto>
	{

	}
}
