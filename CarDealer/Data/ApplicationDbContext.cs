using CarDealer.Models;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.Data;

public class ApplicationDbContext : DbContext 
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{

	}

	public DbSet<Car> Cars { get; set; }
}