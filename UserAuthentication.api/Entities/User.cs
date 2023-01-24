namespace UserAuthentication.api.Entities
{
	public class User
	{
		public int Id { get; set; }
		public int IdApi { get; set; }
		public int IdRole { get; set; }
		public string Email { get; set; } = string.Empty;
		public string? Username { get; set; }
		public string Password { get; set; } = string.Empty;
	}
}
