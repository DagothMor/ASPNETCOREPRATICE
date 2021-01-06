using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Repositories.Interfaces.CRUD;

namespace ASPNETHomework.Repositories.Interfaces
{
	/// <summary>
	/// Product repository,implemented all CRUD operations.
	/// </summary>
	public interface IProductRepository : ICrudRepository<ProductDto,Product>
	{
	}
}
