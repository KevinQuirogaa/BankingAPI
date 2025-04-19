using BankingAPI.Modules.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankingAPI.Modules.Infrastructure.Data
{
    public class BankingDbContext : DbContext
    {
        /// <summary>
        /// Constructor que contiene las configuracioness necesarias para
        /// el contexto de la base de datos
        /// </summary>
        /// <param name="options"></param>
        public BankingDbContext(DbContextOptions<BankingDbContext> options) 
            : base(options)
        {
        }

        /// <summary>
        /// DbSet es la representacion de una tabla por medio de una entidad
        /// Puede interactuar con la DB utilizando LINQ para realizar un CRUD
        /// </summary>
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<AccountEntity> Accounts { get; set; }
        public DbSet<TransactionEntity> Transactions { get; set; }


        /// <summary>
        /// Metodo de EF para modificar el modelo de datos
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*   Entidad CustomerEntity    */

            // Indica que el campo Email de la entidad CustomerEntity
            // va a ser un valor unico
            modelBuilder.Entity<CustomerEntity>()
                .HasIndex(c => c.Email)
                .IsUnique();

            // Indica que el campo CreatedAt de la entidad CustomerEntity
            // va a tener un valor por defecto
            modelBuilder.Entity<CustomerEntity>()
                .Property(c => c.CreatedAt)
                .HasDefaultValueSql("GETDATE()");



            /*   Entidad AccountEntity  */ 

            // Indica que el campo AccountNumber de la entidad AccountEntity
            // va a ser un valor unico
            modelBuilder.Entity<AccountEntity>()
                .HasIndex(c => c.AccountNumber)
                .IsUnique();

            // Indica que el campo Balance de la entidad AccountEntity
            // va tener una presicion de 8 , 2
            modelBuilder.Entity<AccountEntity>()
                .Property(c => c.Balance)
                .HasPrecision(18, 2);


            /*   Entidad TransactionEntity  */

            // Indica que el campo TransactionDate de la entidad TransactionEntity
            // va a tener un valor por defecto
            modelBuilder.Entity<TransactionEntity>()
                .Property(c => c.TransactionDate)
                .HasDefaultValueSql("GETDATE()");

            // Indica que el campo Amount de la entidad TransactionEntity
            // va tener una presicion de 8 , 2
            modelBuilder.Entity<TransactionEntity>()
                .Property(c => c.Amount)
                .HasPrecision(18, 2);

        }
    }
}
