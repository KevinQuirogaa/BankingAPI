using AutoMapper;
using BankingAPI.Modules.Banking.Infrastructure.Data;

namespace BankingAPI.Modules.Banking.Infrastructure.Repositories
{
    public class BaseDbContext
    {
        // Instancia del contexto de la app
        protected readonly BankingDbContext _bankingDbContext;

        // Instancia del mapeador
        protected readonly IMapper _mapper;

        /// <summary>
        /// Constructor donde se inyecta el contexto y el map para usarlas en 
        /// las clases que las heredan
        /// </summary>
        /// <param name="bankingDbContext"></param>
        /// <param name="mapper"></param>
        public BaseDbContext(BankingDbContext bankingDbContext, IMapper mapper)
        {
            _bankingDbContext = bankingDbContext;
            _mapper = mapper;
        }
    }
}
