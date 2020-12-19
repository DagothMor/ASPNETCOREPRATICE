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
			return await _unitOfWork.Orders.CreateAsync(dto);
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
