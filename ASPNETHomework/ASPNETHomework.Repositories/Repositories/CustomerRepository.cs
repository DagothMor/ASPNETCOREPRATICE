﻿using ASPNETHomework.DAL.Contexts;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Repositories.Interfaces;
using AutoMapper;

namespace ASPNETHomework.Repositories.Repositories
{
	/// <summary>
	/// Repository for work with entity "Customer".
	/// </summary>
	public class CustomerRepository : BaseRepository<CustomerDto, Customer>, ICustomerRepository
	{
		/// <summary>
		/// initialize an instance <see cref="CustomerRepository"/>.
		/// </summary>
		/// <param name="context">Data context.</param>
		/// <param name="mapper">Mapper.</param>
		public CustomerRepository(AspNetHomeworkContext context, IMapper mapper) : base(context, mapper)
		{
		}
	}
}
