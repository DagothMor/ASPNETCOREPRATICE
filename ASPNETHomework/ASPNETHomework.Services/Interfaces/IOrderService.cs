using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Services.Interfaces.CRUD;

namespace ASPNETHomework.Services.Interfaces
{
	/// <summary>
	/// Test service,implemented all CRUD operations.
	/// </summary>
	public interface IOrderService : ICrudRepository<OrderDto>
	{

	}
}
