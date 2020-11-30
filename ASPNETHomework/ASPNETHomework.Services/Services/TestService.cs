using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Contexts;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Services.Interfaces;
using AutoMapper;

namespace ASPNETHomework.Services.Services
{
	/// <summary>
	/// Test service
	/// </summary>
	public class TestService : ITestService
	{
		private readonly IMapper _mapper;
		private readonly AspNetHomeworkContext _context;

		public TestService(AspNetHomeworkContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		/// <summary>
		/// <inheritdoc cref="ITestService"/>
		/// </summary>
		/// <returns>List of products</returns>
		public IEnumerable<OrderDto> Get()
		{
			var customer = new Customer
			{
				Id = Guid.NewGuid(),
				FirstName = "firstname",
				LastName = "firstnamovich"

			};
			var notebookCategory = new Category {Id = new Guid(), Type = "Notebook"};
			var product1 = new Product
			{
				Id = Guid.NewGuid(),
				Name = "Apple",
				Category = notebookCategory,
				Description = "Cool notebook!buy it now!!!",
				Price = 12000,
			};
			var product2 = new Product
			{
				Id = Guid.NewGuid(),
				Name = "Banana",
				Category = notebookCategory,
				Description = "very good notebook!Please buy or my boss fired me",
				Price = 24000,
			};
			var order = new Order
			{
				Customer = customer,
				Date = DateTime.Today,
				Time = DateTime.UtcNow,
				Id = Guid.NewGuid(),
				Products = new List<Product>()
			};
			order.Products.Add(product1);
			order.Products.Add(product2);

			_context.Customers.Add(customer);
			_context.Categories.Add(notebookCategory);
			_context.Products.Add(product1);
			_context.Products.Add(product2);
			_context.Orders.Add(order);
			return _mapper.Map<IEnumerable<OrderDto>>(_context.Orders);

		}
	}
}
