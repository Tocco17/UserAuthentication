using UserAuthentication.api.Contexts;
using UserAuthentication.api.Entities;
using UserAuthentication.api.Models;

namespace UserAuthentication.api.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly IContext _context;

		public UserRepository(IContext context)
		{
			_context = context;
		}

		public Task<User> CreateAsync(UserDto user)
		{
			throw new NotImplementedException();
		}

		public Task<User> GetUserFromEmail(string email)
		{
			throw new NotImplementedException();
		}

		public Task<User> GetUserFromUsername(string username)
		{
			throw new NotImplementedException();
		}
	}
}
