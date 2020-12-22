using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Services.Interfaces.CRUD;

namespace ASPNETHomework.Services.Interfaces
{
	/// <summary>
	/// Product service,implemented all CRUD operations.
	/// </summary>
	public interface IProductService : ICrudRepository<ProductDto>
	{
	}
}
