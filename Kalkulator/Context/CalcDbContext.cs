using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Kalkulator.Models;

namespace Kalkulator.Context
{
	public class CalcDbContext : IdentityDbContext<UserModel, IdentityRole<int>, int>
	{
		public CalcDbContext(DbContextOptions<CalcDbContext> options) : base(options)
		{

		}
		public DbSet<CalculatorViewModel> CalculatorViewModels { get; set; }
	}
}
