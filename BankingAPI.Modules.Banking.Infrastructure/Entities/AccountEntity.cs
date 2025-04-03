using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BankingAPI.Modules.Banking.Infrastructure.Entities
{
    [Table("Accounts")]
    [Index(nameof(AccountNumber), IsUnique = true)]
    public class AccountEntity
    {
        /// <summary>
        /// Representa el identificador único de la cuenta.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Representa el número de cuenta del cliente.
        /// </summary>
        [Required]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Representa el tipo de cuenta (Ejemplo: Corriente, Ahorro).
        /// </summary>
        [Required]
        public string AccountType { get; set; }

        /// <summary>
        /// Representa el saldo actual de la cuenta con una precisión de 18 enteros y 2 decimales.
        /// </summary>
        [Required]
        [Precision(18, 2)]
        public decimal Balance { get; set; }

        /// <summary>
        /// Representa la fecha de creación de la cuenta.
        /// </summary>
        [Required]
        public DateOnly CreatedAt { get; set; }

        /// <summary>
        /// Representa el identificador del cliente asociado a la cuenta.
        /// </summary>
        [Required, ForeignKey("Customer")]
        public int CustomerId { get; set; }

        /// <summary>
        /// Representa la relación con la entidad de cliente.
        /// </summary>
        public CustomerEntity Customer { get; set; }
    }
}
