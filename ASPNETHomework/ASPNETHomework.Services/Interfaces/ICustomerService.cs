using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Repositories.Interfaces.CRUD;
using ASPNETHomework.Services.Interfaces.CRUD;

namespace ASPNETHomework.Services.Interfaces
{
	/// <summary>
	/// Customer service,implemented all CRUD operations.
	/// </summary>
	public interface ICustomerService : ICrudRepository<CustomerDto>
	{
	}
}
