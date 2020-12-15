using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Contexts;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Repositories.Interfaces;
using AutoMapper;

namespace ASPNETHomework.Repositories.Repositories
{
	/// <summary>
	/// Repository for work with entity "Order".
	/// </summary>
	public class OrderRepository : BaseRepository<OrderDto, Order>, IOrderRepository
	{
		/// <summary>
		/// initialize an instance <see cref="OrderRepository"/>.
		/// </summary>
		/// <param name="context">Data context.</param>
		/// <param name="mapper">Mapper.</param>
		public OrderRepository(AspNetHomeworkContext context, IMapper mapper) : base(context, mapper)
		{
		}
	}
}
