using AutoMapper;
using BankingAPI.Modules.Banking.BO.Contracts;
using BankingAPI.Modules.Banking.BO.Models;
using BankingAPI.Modules.Banking.Infrastructure.Data;
using BankingAPI.Modules.Banking.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankingAPI.Modules.Banking.Infrastructure.Repositories
{
    public class CustomerRepository: BaseDbContext , ICustomerRepository
    {
        // Constructor base para heredar el contexto y el mapeo 
        public CustomerRepository(BankingDbContext bankingDbContext, IMapper mapper)
            :base(bankingDbContext, mapper)
        {
        }

        // Netodo asincronico para agregar un cliente
        public async Task<CustomerModel> AddCustomer(CustomerModel customer)
        {
            // Mapearlo de un modelo a una entidad
            var customerEntity = _mapper.Map<CustomerEntity>(customer);

            // Agrega la entidad al contexto de la tabla "Customers"
            await _bankingDbContext.Customers.AddAsync(customerEntity);

            // Guarda los cambios en la base de datos
            await _bankingDbContext.SaveChangesAsync();

            // Vuelve a mapearlo con los datos pero de una entidad al modelo
            return _mapper.Map<CustomerModel>(customerEntity);
        }

        // Metodo asincronico para listar todos los clientes
        public async Task<IEnumerable<CustomerModel>> GetAllCustomer()
        {
            // Obtiene todos los registros de la tabla "Customers" desde el contexto
            var customerEntity = await _bankingDbContext.Customers.ToListAsync();

            // Retornar el mapeo de una entidad hacia un modelo
            return _mapper.Map<IEnumerable<CustomerModel>>(customerEntity);
        }

        // Metodo asincronico para obtener un registro especifico de un cliente
        public async Task<CustomerModel> GetCustomerById(int id)
        {
            // Obtiene un registro especifico de la tabla "Customers" desde el contexto
            var customerEntity = await _bankingDbContext.Customers.FindAsync(id);

            // Retornar el mapeo de una entidad hacia un modelo
            return _mapper.Map<CustomerModel>(customerEntity);
        }

        // Metodo asincronico para actualizar un client
        public async Task<CustomerModel> UpdateCustomer(CustomerModel customer)
        {
            // Mapear el modelo a una entidad
            var customerEntity = _mapper.Map<CustomerEntity>(customer);

            // Limpiar el seguimiento de cambios
            _bankingDbContext.ChangeTracker.Clear();

            // Actualiza la entidad en el contexto de la tabla "Customers"
            _bankingDbContext.Customers.Update(customerEntity);

            // Guardar los cambios para la base de datos
            await _bankingDbContext.SaveChangesAsync();

            // Retornar el mapeo de una entidad hacia un modelo
            return _mapper.Map<CustomerModel>(customerEntity);
        }

        // Metodo asincronico para eliminar un cliente
        public async Task DeleteCustomer(CustomerModel customer)
        {
            // Mapea el modelo hacia una entidad
            var customerEnity = _mapper.Map<CustomerEntity>(customer);

            // Limpiar el seguimiento de cambios
            _bankingDbContext.ChangeTracker.Clear();

            // Elimina la entidad en el contexto de la tabla "Customers"
            _bankingDbContext.Customers.Remove(customerEnity);

            // Guardar los cambios para la base de datos
            await _bankingDbContext.SaveChangesAsync();
        }
    }
}
