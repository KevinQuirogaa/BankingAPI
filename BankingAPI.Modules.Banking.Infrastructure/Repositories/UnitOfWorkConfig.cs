using AutoMapper;
using BankingAPI.Modules.Banking.BO.Contracts;
using BankingAPI.Modules.Banking.Infrastructure.Data;

namespace BankingAPI.Modules.Banking.Infrastructure.Repositories
{
    public class UnitOfWorkConfig : IUoWConfig
    {
        // Variables para almacenar el contexto y el mapeo
        protected readonly BankingDbContext _bankingDbContext;
        protected readonly IMapper _mapper;

        // Constructor para acceder al contexto y el mapeo y asignarlo a las variables
        public UnitOfWorkConfig(BankingDbContext context, IMapper mapper)
        {
            _bankingDbContext = context;
            _mapper = mapper;
        }

        // Campo privado para almacenar la instancia del repositorio
        ICustomerRepository _customerRepository;


        /// <summary>
        /// Metodo Lazy Loading que retorna el repositorio unicamente
        /// cuando se inicializa por primera vez
        /// </summary>
        public ICustomerRepository CustomerRepository 
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(_bankingDbContext, _mapper);
                }
                return _customerRepository;
            }
        }

        // Metodo para guardar los cambios en la base de datos de forma sincronica
        public void Commit() => _bankingDbContext.SaveChanges();

        // Metodo para guardar los cambios en la base de datos de forma asincronica
        public async Task CommitAsync() => await _bankingDbContext.SaveChangesAsync();

        // Metodo para limpiar los cambios del contexto de forma asincronica
        public async Task ContextClear()
        {
            _bankingDbContext.ChangeTracker.Clear();
            _bankingDbContext?.ChangeTracker?.Clear();
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _bankingDbContext?.Dispose();
                _bankingDbContext?.Dispose();
            }
        }
    }
}
