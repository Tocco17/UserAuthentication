using UserAuthentication.api.Entities;
using UserAuthentication.api.Models;

namespace UserAuthentication.api.Repositories
{
	public interface IUserRepository
	{
		Task<User> CreateAsync(UserDto user);
		Task<User> GetUserFromEmail(string email);
		Task<User> GetUserFromUsername(string username);
	}
}
