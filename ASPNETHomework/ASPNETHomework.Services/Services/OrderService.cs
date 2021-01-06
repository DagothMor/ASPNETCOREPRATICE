using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Repositories.Interfaces;
using ASPNETHomework.Services.Interfaces;
using ASPNETHomework.Repositories.Interfaces.CRUD;
using ASPNETHomework.DAL;
using System.Linq;

namespace ASPNETHomework.Services.Services
{
	/// <summary>
	/// Service for work data about Order.
	/// </summary>
	public class OrderService : IOrderService
	{
		private readonly UnitOfWork _unitOfWork;

		/// <summary>
		/// Initialize an instance <see cref="OrderService"/>.
		/// </summary>
		/// <param name="UnitOfWork">UnitOfWork.</param>
		public OrderService(UnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		///<inheritdoc cref="ICreatable{TDto}.CreateAsync(TDto)"/>
		public async Task<OrderDto> CreateAsync(OrderDto dto)
		{
			using var scope = await _unitOfWork.Orders.Context.Database.BeginTransactionAsync();
			try
			{
				if (dto.Products.Sum(x => x.Price) > dto.Customer.Money)
				{
					throw new Exception("Not enough money");
				}
				else
				{
					//TODO:определиться уже наконец с типом данных денег
					dto.Customer.Money -= (float)dto.Products.Sum(x => x.Price);
					var customer = new CustomerDto();
					customer.Id = dto.Customer.Id;
					customer.FirstName = dto.Customer.FirstName;
					customer.LastName = dto.Customer.LastName;
					customer.Money = dto.Customer.Money;
					customer.City = dto.Customer.City;
					await _unitOfWork.Customers.UpdateAsync(customer);
					var order = await _unitOfWork.Orders.CreateAsync(dto);
					scope.Commit();
					return order;
				}
			}
			catch (Exception ex)
			{
				scope.Rollback();
				throw ex;
			}
		}

		/// <inheritdoc cref="IDeletable.DeleteAsync(int[])"/>
		public async Task DeleteAsync(params int[] ids)
		{
			await _unitOfWork.Orders.DeleteAsync(ids);
		}

		/// <inheritdoc cref="IGettableById{TDto}.GetAsync(int, CancellationToken)"/>
		public async Task<OrderDto> GetAsync(int id, CancellationToken token = default)
		{
			return await _unitOfWork.Orders.GetAsync(id);
		}

		/// <inheritdoc cref="IGettable{TDto}.GetAsync(CancellationToken)"/>
		public async Task<IEnumerable<OrderDto>> GetAsync(CancellationToken token = default)
		{
			return await _unitOfWork.Orders.GetAsync(token);
		}

		/// <inheritdoc cref="IUpdatable{TDto}.UpdateAsync(TDto)"/>
		public async Task<OrderDto> UpdateAsync(OrderDto dto)
		{
			return await _unitOfWork.Orders.UpdateAsync(dto);
		}
	}
}
