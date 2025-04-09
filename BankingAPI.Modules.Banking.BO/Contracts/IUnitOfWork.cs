namespace BankingAPI.Modules.Banking.BO.Contracts
{
    public interface IUnitOfWork: IDisposable
    {
        Task CommitAsync();
        void Commit();
        Task ContextClear();
    }
}
