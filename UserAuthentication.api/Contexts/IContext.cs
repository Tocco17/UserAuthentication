using Dapper;
using System.Data;

namespace UserAuthentication.api.Contexts
{
	public interface IContext
	{
		public Task<T> CreateAsync<T>(string query);
		public Task<T> CreateAsync<T>(string storedProcedure, DynamicParameters parameters);
		public IDbConnection CreateConnection();
		public Task<IEnumerable<T>> GetAsync<T>(string query);
		public Task<IEnumerable<T>> GetAsync<T>(string storedProcedure, DynamicParameters parameters);
	}
}
