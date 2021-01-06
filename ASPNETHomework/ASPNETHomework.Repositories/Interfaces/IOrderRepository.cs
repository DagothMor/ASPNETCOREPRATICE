﻿using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Repositories.Interfaces.CRUD;
using ASPNETHomework.Models.DTO;


namespace ASPNETHomework.Repositories.Interfaces
{
	/// <summary>
	/// Order repository,implemented all CRUD operations.
	/// </summary>
	public interface IOrderRepository : ICrudRepository<OrderDto, Order>
	{

	}
}
