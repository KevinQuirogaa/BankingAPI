using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankingAPI.Modules.Infrastructure.Entities
{
    [Table("Accounts")]
    public class AccountEntity
    {
        [Key, Required]
        public string AccountNumber { get; set; }

        [Required, ForeignKey("Customer")]
        public int CustomerId { get; set; }


        [Required]
        public string AccountType { get; set; }

        [Required]
        public decimal Balance { get; set; }


        // Relacion de CustomerId a CustomerEntity Id
        public CustomerEntity Customer { get; set; }
    }
}
