namespace BankingAPI.Modules.Banking.BO.Contracts
{
    public interface IUoWConfig: IUnitOfWork
    {
        // Solo permite llamar la interfaz del repositorio pero no modificar
        public ICustomerRepository CustomerRepository { get; }
    }
}
