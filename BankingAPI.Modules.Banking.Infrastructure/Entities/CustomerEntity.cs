using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BankingAPI.Modules.Banking.Infrastructure.Entities
{
    [Table("Customers")]
    [Index(nameof(Email), IsUnique = true)] 
    public class CustomerEntity
    {
        /// <summary>
        /// Representa el identificador único del cliente.
        /// </summary>
        [Key]
        public int Id { get; set; }


        /// <summary>
        /// Representa el primer nombre del cliente.
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Representa el apellido del cliente.
        /// </summary>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Representa el número de teléfono del cliente.
        /// </summary>
        [Required]
        public string Phone { get; set; }

        /// <summary>
        /// Representa la fecha de nacimiento del cliente.
        /// </summary>  
        [Required]
        public DateOnly BirthDate { get; set; }

        /// <summary>
        /// Representa la dirección del cliente.
        /// </summary>
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// Representa el correo electrónico del cliente. Debe ser único.
        /// </summary>  
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Representa la contraseña del cliente.
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Representa la fecha de creación del registro.
        /// </summary>
        [Required]
        public DateOnly CreatedAt { get; set; }
    }
}
