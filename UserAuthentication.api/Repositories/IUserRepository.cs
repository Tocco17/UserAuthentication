using UserAuthentication.api.Entities;
using UserAuthentication.api.Models;

namespace UserAuthentication.api.Repositories
{
	public interface IUserRepository
	{
		public Task<User> CreateAsync(UserDto user);
		public Task<User> GetUserFromEmail(string email);
		public Task<User> GetUserFromUsername(string username);
	}
}
