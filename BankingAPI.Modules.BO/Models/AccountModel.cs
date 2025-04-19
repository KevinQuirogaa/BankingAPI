namespace BankingAPI.Modules.BO.Models
{
    public class AccountModel
    {
        public string AccountNumber { get; set; }

        public int CustomerId { get; set; }

        public string AccountType { get; set; }

        public decimal Balance { get; set; }

    }
}
