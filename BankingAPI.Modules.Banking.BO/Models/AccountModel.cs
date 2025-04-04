namespace BankingAPI.Modules.Banking.BO.Models
{
    public class AccountModel
    {
        /// <summary>
        /// Representa el identificador único de la cuenta.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Representa el número de cuenta del cliente.
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Representa el tipo de cuenta (Ejemplo: Corriente, Ahorro).
        /// </summary>
        public string AccountType { get; set; }

        /// <summary>
        /// Representa el saldo actual de la cuenta con una precisión de 18 enteros y 2 decimales.
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// Representa la fecha de creación de la cuenta.
        /// </summary>
        public DateOnly CreatedAt { get; set; }

        /// <summary>
        /// Representa el identificador del cliente asociado a la cuenta.
        /// </summary>
        public int CustomerId { get; set; }
    }
}
