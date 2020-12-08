using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
		private readonly ICustomerRepository _repository;

		/// <summary>
		/// Initialize an instance <see cref="CustomerService"/>.
		/// </summary>
		/// <param name="repository">Repository.</param>
		public CustomerService(ICustomerRepository repository)
		{
			_repository = repository;
		}

		///<inheritdoc cref="ICreatable{TDto}.CreateAsync(TDto)"/>
		public async Task<CustomerDto> CreateAsync(CustomerDto dto)
		{
			return await _repository.CreateAsync(dto);
		}

		/// <inheritdoc cref="IDeletable.DeleteAsync(int[])"/>
		public async Task DeleteAsync(params int[] ids)
		{
			await _repository.DeleteAsync(ids);
		}

		/// <inheritdoc cref="IGettableById{TDto}.GetAsync(int, CancellationToken)"/>
		public async Task<CustomerDto> GetAsync(int id, CancellationToken token = default)
		{
			return await _repository.GetAsync(id);
		}

		/// <inheritdoc cref="IGettable{TDto}.GetAsync(CancellationToken)"/>
		public async Task<IEnumerable<CustomerDto>> GetAsync(CancellationToken token = default)
		{
			return await _repository.GetAsync(token);
		}

		/// <inheritdoc cref="IUpdatable{TDto}.UpdateAsync(TDto)"/>
		public async Task<CustomerDto> UpdateAsync(CustomerDto dto)
		{
			return await _repository.UpdateAsync(dto);
		}
	}
}
