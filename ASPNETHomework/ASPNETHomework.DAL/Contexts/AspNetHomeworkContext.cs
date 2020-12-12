using System;
using System.Collections.Generic;
using System.Text;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.DAL.Fluent;
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
		/// Customers.
		/// </summary>
		public DbSet<Customer> Customers { get; set; }

		/// <summary>
		/// Products.
		/// </summary>
		public DbSet<Product> Products { get; set; }

		/// <summary>
		/// Categories.
		/// </summary>
		public DbSet<Category> Categories { get; set; }

		/// <summary>
		/// Availabilities.
		/// </summary>
		public DbSet<Availability> Availabilities { get; set; }

		/// <summary>
		/// Shops.
		/// </summary>
		public DbSet<Shop> Shops { get; set; }

		/// <summary>
		/// Providers.
		/// </summary>
		public DbSet<Provider> Providers { get; set; }

		/// <summary>
		/// Initialize an instance <see cref="AspNetHomeworkContext"/>
		/// </summary>
		/// <param name="options">options for context configuration</param>
		public AspNetHomeworkContext(DbContextOptions options) : base(options)
		{
		}
		/// <summary>
		/// Entity creating rules.
		/// </summary>
		/// <param name="builder">Model builder.</param>
		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new AvailabilityConfig());
		}
	}
}
