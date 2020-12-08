using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ASPNETHomework.Repositories.Interfaces.CRUD
{
	/// <summary>
	/// Interface for update an instance.
	/// </summary>
	/// <typeparam name="TDto">DTO.</typeparam>
	/// <typeparam name="TModel">Domain model.</typeparam>
	public interface IUpdatable<TDto, TModel>
	{
		/// <summary>
		/// Update entity.
		/// </summary>
		/// <param name="dto">DTO.</param>
		/// <param name="token">Instance <see cref="CancellationToken"/>.</param>
		/// <returns>Updated entity.</returns>
		Task<TDto> UpdateAsync(TDto dto, CancellationToken token = default);
	}
}
