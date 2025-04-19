using AutoMapper;
using BankingAPI.Modules.BO.Models;
using BankingAPI.Modules.Infrastructure.Entities;

namespace BankingAPI.Modules.Infrastructure.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // Pasar datos del objeto de una entidad al modelo y viceversa
            CreateMap<CustomerEntity, CustomerModel>().ReverseMap();
            CreateMap<AccountEntity, AccountModel>().ReverseMap();
            CreateMap<TransactionEntity, TransactionModel>().ReverseMap();
        }
    }
}
