using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ASPNETHomework.DAL.Contexts;
using ASPNETHomework.DAL.Domain;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Repositories.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ASPNETHomework.Repositories.Repositories
{
	/// <summary>
	/// Repository for work with entity "Product".
	/// </summary>
	public class ProductRepository : BaseRepository<ProductDto,Product>, IProductRepository
	{
		/// <summary>
		/// initialize an instance <see cref="ProductRepository"/>.
		/// </summary>
		/// <param name="context">Data context.</param>
		/// <param name="mapper">Mapper.</param>
		public ProductRepository(AspNetHomeworkContext context, IMapper mapper) : base(context, mapper)
		{
		}
		/// <inheritdoc/>
		protected override IQueryable<Product> DefaultIncludeProperties(DbSet<Product> dbSet)
		{
			return dbSet.Include(x => x.Provider);
		}
	}
}
