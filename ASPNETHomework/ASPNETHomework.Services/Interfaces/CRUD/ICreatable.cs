using System.Threading.Tasks;

namespace ASPNETHomework.Services.Interfaces.CRUD
{
	/// <summary>
	/// Interface for create entity.
	/// </summary>
	/// <typeparam name="TDto">DTO.</typeparam>
	public interface ICreatable<TDto>
	{
		/// <summary>
		/// Create entity.
		/// </summary>
		/// <param name="dto">DTO.</param>
		/// <returns>Id created entity.</returns>
		Task<TDto> CreateAsync(TDto dto);
	}
}
