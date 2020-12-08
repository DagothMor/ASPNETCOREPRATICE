using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETHomework.Repositories.Interfaces.CRUD
{
	/// <summary>
	/// Interface for Delete entities.
	/// </summary>
	/// <typeparam name="TDto">DTO.</typeparam>
	/// <typeparam name="TModel">Domain model.</typeparam>
	public interface IDeletable
	{
		/// <summary>
		/// Delete entities by a group.
		/// </summary>
		/// <param name="ids">Identifications.</param>
		/// <returns>task,which return async operation.</returns>
		Task DeleteAsync(params Guid[] ids);
	}
}
