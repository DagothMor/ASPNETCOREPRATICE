using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ASPNETHomework.DAL;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Repositories.Interfaces;
using ASPNETHomework.Services.Interfaces;

namespace ASPNETHomework.Services.Services
{
	/// <summary>
	/// Service for work data about Customer.
	/// </summary>
	public class CustomerService : ICustomerService
	{
		private readonly UnitOfWork _unitOfWork;

		/// <summary>
		/// Initialize an instance <see cref="CustomerService"/>.
		/// </summary>
		/// <param name="UnitOfWork">UnitOfWork.</param>
		public CustomerService(UnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		///<inheritdoc cref="ICreatable{TDto}.CreateAsync(TDto)"/>
		public async Task<CustomerDto> CreateAsync(CustomerDto dto)
		{
			return await _unitOfWork.Customers.CreateAsync(dto);
		}

		/// <inheritdoc cref="IDeletable.DeleteAsync(int[])"/>
		public async Task DeleteAsync(params int[] ids)
		{
			await _unitOfWork.Customers.DeleteAsync(ids);
		}

		/// <inheritdoc cref="IGettableById{TDto}.GetAsync(int, CancellationToken)"/>
		public async Task<CustomerDto> GetAsync(int id, CancellationToken token = default)
		{
			return await _unitOfWork.Customers.GetAsync(id);
		}

		/// <inheritdoc cref="IGettable{TDto}.GetAsync(CancellationToken)"/>
		public async Task<IEnumerable<CustomerDto>> GetAsync(CancellationToken token = default)
		{
			return await _unitOfWork.Customers.GetAsync(token);
		}

		/// <inheritdoc cref="IUpdatable{TDto}.UpdateAsync(TDto)"/>
		public async Task<CustomerDto> UpdateAsync(CustomerDto dto)
		{
			return await _unitOfWork.Customers.UpdateAsync(dto);
		}
	}
}
