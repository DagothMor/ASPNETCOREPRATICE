using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ASPNETHomework.Services.Interfaces.CRUD
{
	/// <summary>
	/// Interface for get entities.
	/// </summary>
	/// <typeparam name="TDto">DTO.</typeparam>
	public interface IGettable<TDto>
	{
		/// <summary>
		/// Get entities.
		/// </summary>
		/// <param name="token">Instance <see cref="CancellationToken"/>.</param>
		/// <returns></returns>
		Task<IEnumerable<TDto>> GetAsync(CancellationToken token = default);
	}	
}
