using System.ComponentModel.DataAnnotations;

namespace BankingAPI.Modules.Banking.BO.Dtos.Request
{
    public class CustomerRequest
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Phone { get; set; }


        [Required]
        public DateOnly BirthDate { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateOnly CreatedAt { get; set; }
    }
}
