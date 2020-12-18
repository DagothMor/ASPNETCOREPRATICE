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
	public class ProductService : IProductService
	{
		private readonly UnitOfWork _unitOfWork;

		/// <summary>
		/// Initialize an instance <see cref="ProductService"/>.
		/// </summary>
		/// <param name="repository">Repository.</param>
		public ProductService(UnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		///<inheritdoc cref="ICreatable{TDto}.CreateAsync(TDto)"/>
		/// Test Create
		public async Task<ProductDto> CreateAsync(ProductDto dto)
		{
			using var scope = await _unitOfWork.Products.Context.Database.BeginTransactionAsync();
			try
			{
				var product = await _unitOfWork.Products.CreateAsync(dto);
				scope.Commit();
				return product;
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
			await _unitOfWork.Products.DeleteAsync(ids);
		}

		/// <inheritdoc cref="IGettableById{TDto}.GetAsync(int, CancellationToken)"/>
		public async Task<ProductDto> GetAsync(int id, CancellationToken token = default)
		{
			return await _unitOfWork.Products.GetAsync(id);
		}

		/// <inheritdoc cref="IGettable{TDto}.GetAsync(CancellationToken)"/>
		public async Task<IEnumerable<ProductDto>> GetAsync(CancellationToken token = default)
		{
			return await _unitOfWork.Products.GetAsync(token);
		}

		/// <inheritdoc cref="IUpdatable{TDto}.UpdateAsync(TDto)"/>
		public async Task<ProductDto> UpdateAsync(ProductDto dto)
		{
			return await _unitOfWork.Products.UpdateAsync(dto);
		}
	}
}
//попробую создать внутри сервиса уов
