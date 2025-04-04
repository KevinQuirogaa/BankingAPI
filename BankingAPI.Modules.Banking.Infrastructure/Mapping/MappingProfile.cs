using AutoMapper;
using BankingAPI.Modules.Banking.BO.Models;
using BankingAPI.Modules.Banking.Infrastructure.Entities;

namespace BankingAPI.Modules.Banking.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        // Constructor donde se condigura el mapeo
        public MappingProfile()
        {
            // Mapear un objeto a otro y viceversa.
            CreateMap<CustomerModel, CustomerEntity>().ReverseMap();
        }
    }
}
