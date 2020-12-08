using System;
using System.Collections.Generic;
using System.Text;

namespace ASPNETHomework.Repositories.Interfaces.CRUD
{
	/// <summary>
	/// Interface repository with based CRUD-operations.
	/// </summary>
	/// <typeparam name="TDto"></typeparam>
	/// <typeparam name="TModel"></typeparam>
	public interface ICrudRepository<TDto, TModel> :
		ICreatable<TDto, TModel>,
		IGettableById<TDto, TModel>,
		IGettable<TDto, TModel>,
		IUpdatable<TDto, TModel>,
		IDeletable
	{
	}
}
