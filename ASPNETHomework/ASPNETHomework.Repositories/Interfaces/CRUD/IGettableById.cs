using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETHomework.Repositories.Interfaces.CRUD
{
	/// <summary>
	/// Interface for get entity by id.
	/// </summary>
	/// <typeparam name="TDto">DTO.</typeparam>
	/// <typeparam name="TModel">Domain model.</typeparam>
	public interface IGettableById<TDto, TModel>
	{
		/// <summary>
		/// Get entity by id.
		/// </summary>
		/// <param name="id">Identification.</param>
		/// <returns>Entity instance.</returns>
		Task<TDto> GetAsync(int id);
	}
}
