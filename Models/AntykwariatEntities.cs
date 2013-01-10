using System.Data.Entity;

namespace Antykwariat.Models
{
    public class AntykwariatEntities : DbContext
    {
        public DbSet<Ksiazka> Ksiazki { get; set; }
        public DbSet<Gatunek> Gatunki { get; set; }
        public DbSet<Autor> Autorzy { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}