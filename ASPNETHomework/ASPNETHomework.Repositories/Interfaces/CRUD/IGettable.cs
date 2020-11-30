using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ASPNETHomework.Repositories.Interfaces.CRUD
{
	/// <summary>
	/// Interface for get entities.
	/// </summary>
	/// <typeparam name="TDto">DTO.</typeparam>
	/// <typeparam name="TModel">Domain model.</typeparam>
	public interface IGettable<TDto, TModel>
	{
		/// <summary>
		/// Get entities.
		/// </summary>
		/// <param name="token">Instance <see cref="CancellationToken"/>.</param>
		/// <returns></returns>
		Task<IEnumerable<TDto>> GetAsync(CancellationToken token = default);
	}	
}
