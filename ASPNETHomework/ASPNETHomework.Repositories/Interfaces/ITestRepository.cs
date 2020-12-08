using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Repositories.Interfaces.CRUD;
using ASPNETHomework.Models.DTO;


namespace ASPNETHomework.Repositories.Interfaces
{
	public interface ITestRepository : ICrudRepository<OrderDto, Order>
	{

	}
}
