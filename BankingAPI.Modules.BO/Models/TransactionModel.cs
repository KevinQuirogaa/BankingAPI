namespace BankingAPI.Modules.BO.Models
{
    public class TransactionModel
    {
        public int Id { get; set; }

        public string AccountNumber { get; set; }

        public DateTime TransactionDate { get; set; }

        public decimal Amount { get; set; }

        public string TransactionType { get; set; }
    }
}
