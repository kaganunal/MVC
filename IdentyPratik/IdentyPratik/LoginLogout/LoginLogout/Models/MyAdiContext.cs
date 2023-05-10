using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginLogout.Models
{
	
	public class MyAdiContext : IdentityDbContext<AppUser>
	{
		public MyAdiContext()
		{

		}

		public MyAdiContext(DbContextOptions<MyAdiContext> options) : base(options)
		{
		}

		public virtual DbSet<AppUser> Users { get; set; }
	}
}
