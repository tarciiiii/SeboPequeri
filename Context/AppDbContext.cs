using Microsoft.EntityFrameworkCore;

namespace SeboPequeri.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoLivro> PedidoLivros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PedidoLivro>()
                .HasKey(pl => new { pl.PedidoId, pl.LivroId });

            modelBuilder.Entity<PedidoLivro>()
                .HasOne(pl => pl.Pedido)
                .WithMany(p => p.PedidoLivros)
                .HasForeignKey(pl => pl.PedidoId);

            modelBuilder.Entity<PedidoLivro>()
                .HasOne(pl => pl.Livro)
                .WithMany()
                .HasForeignKey(pl => pl.LivroId);
        }
    }
}
