using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Kalkulator.Models;

namespace Kalkulator.Context
{
	public class DbContext : IdentityDbContext<UserModel, IdentityRole<int>, int>
	{
		public DbContext(DbContextOptions<DbContext> options) : base(options)
		{

		}
	
	}
}
