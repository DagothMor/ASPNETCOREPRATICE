using System.Threading.Tasks;


namespace ASPNETHomework.Repositories.Interfaces.CRUD
{
	/// <summary>
	/// Interface for create entity.
	/// </summary>
	/// <typeparam name="TDto">DTO.</typeparam>
	/// <typeparam name="TModel">Domain model.</typeparam>
	public interface ICreatable<TDto, TModel>
	{
		/// <summary>
		/// Create entity.
		/// </summary>
		/// <param name="dto">DTO.</param>
		/// <returns>Id created entity.</returns>
		Task<TDto> CreateAsync(TDto dto);
	}
}
