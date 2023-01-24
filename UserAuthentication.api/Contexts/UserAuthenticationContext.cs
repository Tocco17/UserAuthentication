﻿using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;

namespace UserAuthentication.api.Contexts
{
	public class UserAuthenticationContext : IContext
	{
		private readonly IConfiguration _configuration;
		private readonly string _connectionString;

		public UserAuthenticationContext(IConfiguration configuration)
		{
			_configuration= configuration;
			_connectionString = _configuration.GetConnectionString("SqlConnection");
		}

		public Task<T> CreateAsync<T>(string query)
		{
			using (var conn = CreateConnection())
			{
				return conn.QuerySingleOrDefaultAsync<T>(query);
			}
		}

		public Task<T> CreateAsync<T>(string storedProcedure, DynamicParameters parameters)
		{
			using (var conn = CreateConnection())
			{
				return conn.QuerySingleOrDefaultAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
			}
		}

		public IDbConnection CreateConnection() => new SqlConnection(_connectionString);

		public Task<IEnumerable<T>> GetAsync<T>(string query)
		{
			using (var conn = CreateConnection())
			{
				return conn.QueryAsync<T>(query);
			}
		}

		public Task<IEnumerable<T>> GetAsync<T>(string storedProcedure, DynamicParameters parameters)
		{
			using (var conn = CreateConnection())
			{
				return conn.QueryAsync<T> (storedProcedure, parameters, commandType: CommandType.StoredProcedure);
			}
		}
	}
}
