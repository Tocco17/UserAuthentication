namespace UserAuthentication.api.Entities
{
	public class Role
	{
		public int Id { get; set; }
		public int IdApi { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public int AuthLevel { get; set; }
	}
}
