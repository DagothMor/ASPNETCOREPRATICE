using System;
using System.Threading;
using System.Threading.Tasks;

namespace ASPNETHomework.Services.Interfaces.CRUD
{
	/// <summary>
	/// Interface for get entity by id.
	/// </summary>
	/// <typeparam name="TDto">DTO.</typeparam>
	public interface IGettableById<TDto>
	{
		/// <summary>
		/// Get entity by id.
		/// </summary>
		/// <param name="id">Identification.</param>
		/// <returns>Entity instance.</returns>
		Task<TDto> GetAsync(Guid id, CancellationToken token = default);
	}
}
