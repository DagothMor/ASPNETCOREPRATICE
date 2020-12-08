using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ASPNETHomework.Models.DTO;
using ASPNETHomework.Repositories.Interfaces;
using ASPNETHomework.Services.Interfaces;
using ASPNETHomework.Repositories.Interfaces.CRUD;

namespace ASPNETHomework.Services.Services
{
	/// <summary>
	/// Service for work data about Order.
	/// </summary>
	public class TestService : ITestService
	{
		private readonly ITestRepository _repository;

		/// <summary>
		/// Initialize an instance <see cref="TestService"/>.
		/// </summary>
		/// <param name="repository">Repository.</param>
		public TestService(ITestRepository repository)
		{
			_repository = repository;
		}

		///<inheritdoc cref="ICreatable{TDto}.CreateAsync(TDto)"/>
		public async Task<OrderDto> CreateAsync(OrderDto dto)
		{
			return await _repository.CreateAsync(dto);
		}

		/// <inheritdoc cref="IDeletable.DeleteAsync(Guid[])"/>
		public async Task DeleteAsync(params Guid[] ids)
		{
			await _repository.DeleteAsync(ids);
		}

		/// <inheritdoc cref="IGettableById{TDto}.GetAsync(Guid, CancellationToken)"/>
		public async Task<OrderDto> GetAsync(Guid id, CancellationToken token = default)
		{
			return await _repository.GetAsync(id);
		}

		/// <inheritdoc cref="IGettable{TDto}.GetAsync(CancellationToken)"/>
		public async Task<IEnumerable<OrderDto>> GetAsync(CancellationToken token = default)
		{
			return await _repository.GetAsync(token);
		}

		/// <inheritdoc cref="IUpdatable{TDto}.UpdateAsync(TDto)"/>
		public async Task<OrderDto> UpdateAsync(OrderDto dto)
		{
			return await _repository.UpdateAsync(dto);
		}
	}
}
