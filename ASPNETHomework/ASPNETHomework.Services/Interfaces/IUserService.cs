using ASPNETHomework.Models.DTO;
using ASPNETHomework.Services.Interfaces.CRUD;

namespace ASPNETHomework.Services.Interfaces
{
	/// <summary>
	/// Interface for service user.
	/// </summary>
	public interface IUserService : ICrudRepository<UserDto>
	{
		/// <summary>
		/// Check user.
		/// </summary>
		bool IsAnExistingUser(string userName);

		/// <summary>
		/// Validate user data.
		/// </summary>
		bool IsValidUserCredentials(string userName, string password);

		/// <summary>
		/// Get user role if exists.
		/// </summary>
		string GetUserRole(string userName);
	}
}
