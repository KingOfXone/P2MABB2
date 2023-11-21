using Microsoft.EntityFrameworkCore;
using P2MABB.Shared;

namespace P2MABB.Server.DAL
{
	public class VentasContext : DbContext
	{
		public DbSet<Shared.Ventas> Ventas { get; set; }
		public DbSet<Shared.VentasDetalles> VentasDetalles { get; set; }
		public DbSet<Shared.Clientes> Clientes { get; set; }

		public VentasContext(DbContextOptions<VentasContext> options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
		
		}
	}
}
