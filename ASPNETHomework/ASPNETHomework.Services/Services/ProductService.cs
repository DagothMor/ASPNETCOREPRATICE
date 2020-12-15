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
	public class ProductService : IProductService
	{
		private readonly IProductRepository _repository;

		/// <summary>
		/// Initialize an instance <see cref="ProductService"/>.
		/// </summary>
		/// <param name="repository">Repository.</param>
		public ProductService(IProductRepository repository)
		{
			_repository = repository;
		}

		///<inheritdoc cref="ICreatable{TDto}.CreateAsync(TDto)"/>
		public async Task<ProductDto> CreateAsync(ProductDto dto)
		{
			return await _repository.CreateAsync(dto);
		}

		/// <inheritdoc cref="IDeletable.DeleteAsync(int[])"/>
		public async Task DeleteAsync(params int[] ids)
		{
			await _repository.DeleteAsync(ids);
		}

		/// <inheritdoc cref="IGettableById{TDto}.GetAsync(int, CancellationToken)"/>
		public async Task<ProductDto> GetAsync(int id, CancellationToken token = default)
		{
			return await _repository.GetAsync(id);
		}

		/// <inheritdoc cref="IGettable{TDto}.GetAsync(CancellationToken)"/>
		public async Task<IEnumerable<ProductDto>> GetAsync(CancellationToken token = default)
		{
			return await _repository.GetAsync(token);
		}

		/// <inheritdoc cref="IUpdatable{TDto}.UpdateAsync(TDto)"/>
		public async Task<ProductDto> UpdateAsync(ProductDto dto)
		{
			return await _repository.UpdateAsync(dto);
		}
	}
}
