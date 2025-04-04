namespace BankingAPI.Modules.Banking.BO.Models
{
    public class CustomerModel
    {
        /// <summary>
        /// Representa el identificador único del cliente.
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Representa el primer nombre del cliente.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Representa el apellido del cliente.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Representa el número de teléfono del cliente.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Representa la fecha de nacimiento del cliente.
        /// </summary>  
        public DateOnly BirthDate { get; set; }

        /// <summary>
        /// Representa la dirección del cliente.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Representa el correo electrónico del cliente. Debe ser único.
        /// </summary>  
        public string Email { get; set; }

        /// <summary>
        /// Representa la contraseña del cliente.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Representa la fecha de creación del registro.
        /// </summary>
        public DateOnly CreatedAt { get; set; }
    }
}
