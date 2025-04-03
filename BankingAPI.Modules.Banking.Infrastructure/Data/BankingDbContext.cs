using BankingAPI.Modules.Banking.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankingAPI.Modules.Banking.Infrastructure.Data
{
    public class BankingDbContext : DbContext
    {
        /// <summary>
        /// Constructor que contiene las opciones de configuración 
        /// de la base de datos
        /// </summary>
        /// <param name="options"></param>
        public BankingDbContext(DbContextOptions<BankingDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// Propiedad DbSet para crear la estructura en la migracion y
        /// realizar las operaciones CRUD
        /// </summary>
        public DbSet<CustomerEntity> Customers {  get; set; }
        public DbSet<AccountEntity> Accounts { get; set; }
        public DbSet<TransactionEntity> Transactions { get; set; }


        /// <summary>
        /// Metodo para configurar el modelo de la base de datos:
        /// Definir relaciones, llaves primarias y unicas...
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
