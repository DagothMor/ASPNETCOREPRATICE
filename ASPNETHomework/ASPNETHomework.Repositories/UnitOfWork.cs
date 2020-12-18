using System;
using ASPNETHomework.DAL.Contexts;
using ASPNETHomework.Repositories.Repositories;
using AutoMapper;

namespace ASPNETHomework.DAL
{
	/// <summary>
	/// UoW.
	/// </summary>
	public class UnitOfWork : IDisposable
	{
		private AspNetHomeworkContext Context { get; }
		private IMapper Mapper { get; }
		private CustomerRepository _customerRepository;
		private OrderRepository _orderRepository;
		private ProductRepository _productRepository;
		/// <summary>
		/// UoW constructor.
		/// </summary>
		/// <param name="context"></param>
		/// <param name="mapper"></param>

		public UnitOfWork(AspNetHomeworkContext context,IMapper mapper)
		{
			Context = context;
			Mapper = mapper;
		}

		public CustomerRepository Customers
		{
			get
			{
				if (_customerRepository == null)
					_customerRepository = new CustomerRepository(Context,Mapper);// и их же юзать при создании реп?
				return _customerRepository;
			}
		}

		public OrderRepository Orders
		{
			get
			{
				if (_orderRepository == null)
					_orderRepository = new OrderRepository(Context, Mapper);
				return _orderRepository;
			}
		}

		public ProductRepository Products
		{
			get
			{
				if (_productRepository == null)
					_productRepository = new ProductRepository(Context, Mapper);
				return _productRepository;
			}
		}

		public void Save()
		{
			Context.SaveChanges();
		}

		private bool disposed = false;

		public virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					Context.Dispose();
				}
				this.disposed = true;
			}
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
