namespace BankingAPI.Modules.Banking.BO.Models
{
    public class TransationModel
    {
        /// <summary>
        /// Representa el identificador único de la transacción.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Representa el tipo de transacción (Ejemplo: Depósito, Retiro, Transferencia).
        /// </summary>
        public string TransactionType { get; set; }

        /// <summary>
        /// Representa el monto de la transacción con una precisión de 18 enteros y 2 decimales.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Representa la fecha de la transacción en formato de cadena.
        /// Se recomienda usar DateTime en lugar de string.
        /// </summary>
        public string TransactionDate { get; set; }

        /// <summary>
        /// Representa una descripción opcional de la transacción.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Representa el identificador de la cuenta asociada a la transacción.
        /// </summary>
        public int AccountId { get; set; }
    }
}
