using System;
using System.Threading.Tasks;

namespace ASPNETHomework.Services.Interfaces.CRUD
{
	/// <summary>
	/// Interface for Delete entities.
	/// </summary>
	/// <typeparam name="TDto">DTO.</typeparam>
	public interface IDeletable
	{
		/// <summary>
		/// Delete entities by a group.
		/// </summary>
		/// <param name="ids">Identifications.</param>
		/// <returns>task,which return async operation.</returns>
		Task DeleteAsync(params int[] ids);
	}
}
