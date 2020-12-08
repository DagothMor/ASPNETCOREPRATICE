namespace ASPNETHomework.Services.Interfaces.CRUD
{
	/// <summary>
	/// Interface repository with based CRUD-operations.
	/// </summary>
	/// <typeparam name="TDto"></typeparam>
	public interface ICrudRepository<TDto> :
		ICreatable<TDto>,
		IGettableById<TDto>,
		IGettable<TDto>,
		IUpdatable<TDto>,
		IDeletable
	{
	}
}
