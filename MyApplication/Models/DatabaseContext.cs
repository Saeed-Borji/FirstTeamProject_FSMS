namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
		}

		public DatabaseContext()
			: base()
		{
		}

		public System.Data.Entity.DbSet<User> Users { get; set; }
	}
}
