using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingAPI.Modules.Infrastructure.Entities
{
    [Table("Transactions")]
    public class TransactionEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, ForeignKey("Account")]
        public string AccountNumber { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string TransactionType { get; set; }


        // Relacion de AccountNumber a AccountEntity AccountNumber
        public AccountEntity Account { get; set; }
    }
}
