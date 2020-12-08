using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPNETHomework.DAL.Contexts
{
	/// <summary>
	/// Context for work with data in database
	/// </summary>
	public class AspNetHomeworkContext : DbContext
	{
		/// <summary>
		/// Orders.
		/// </summary>
		public DbSet<Order> Orders { get; set; }

		/// <summary>
		/// Categories.
		/// </summary>
		public DbSet<Category> Categories { get; set; }

		/// <summary>
		/// Customers.
		/// </summary>
		public DbSet<Customer> Customers { get; set; }

		/// <summary>
		/// Products.
		/// </summary>
		public DbSet<Product> Products { get; set; }

		/// <summary>
		/// Initialize an instance <see cref="AspNetHomeworkContext"/>
		/// </summary>
		/// <param name="options">options for context configuration</param>
		public AspNetHomeworkContext(DbContextOptions options) : base(options)
		{
			///удаляет бд потом заного создает потому на будущее не заполняй
			/// бд кучей данных
			/// ревертнул по невнимательности
			//Database.EnsureDeleted();
			//Database.EnsureCreated();
		}

	}
}
