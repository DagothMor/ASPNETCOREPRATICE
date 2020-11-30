using System.Threading;
using System.Threading.Tasks;

namespace ASPNETHomework.Services.Interfaces.CRUD
{
	/// <summary>
	/// Interface for update an instance.
	/// </summary>
	/// <typeparam name="TDto">DTO.</typeparam>
	public interface IUpdatable<TDto>
	{
		/// <summary>
		/// Update entity.
		/// </summary>
		/// <param name="dto">DTO.</param>
		/// <param name="token">Instance <see cref="CancellationToken"/>.</param>
		/// <returns>Updated entity.</returns>
		Task<TDto> UpdateAsync(TDto dto);
	}
}
