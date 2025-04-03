using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BankingAPI.Modules.Banking.Infrastructure.Entities
{
    [Table("Transactions")]
    public class TransactionEntity
    {
        /// <summary>
        /// Representa el identificador único de la transacción.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Representa el tipo de transacción (Ejemplo: Depósito, Retiro, Transferencia).
        /// </summary>
        [Required]
        public string TransactionType { get; set; }

        /// <summary>
        /// Representa el monto de la transacción con una precisión de 18 enteros y 2 decimales.
        /// </summary>
        [Required]
        [Precision(18, 2)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Representa la fecha de la transacción en formato de cadena.
        /// Se recomienda usar DateTime en lugar de string.
        /// </summary>
        [Required]
        public string TransactionDate { get; set; }

        /// <summary>
        /// Representa una descripción opcional de la transacción.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Representa el identificador de la cuenta asociada a la transacción.
        /// </summary>
        [Required, ForeignKey("Account")]
        public int AccountId { get; set; }

        /// <summary>
        /// Representa la relación con la entidad de cuenta.
        /// </summary>
        public AccountEntity Account { get; set; }
    }
}
