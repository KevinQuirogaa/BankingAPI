namespace BankingAPI.Modules.Banking.BO.Dtos.Response
{
    public class CustomerResponse
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public DateOnly BirthDate { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateOnly CreatedAt { get; set; }

        public CustomerResponse(string firstName, string lastName, string phone, DateOnly birthDate, string address, string email, string password, DateOnly createdAt)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            BirthDate = birthDate;
            Address = address;
            Email = email;
            Password = password;
            CreatedAt = createdAt;
        }
    }
}
