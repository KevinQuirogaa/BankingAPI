using BankingAPI.Modules.Banking.BO.Contracts;
using BankingAPI.Modules.Banking.BO.Dtos.Request;
using BankingAPI.Modules.Banking.BO.Dtos.Response;
using BankingAPI.Modules.Banking.BO.Models;
using BankingAPI.Modules.Banking.Logic.Interfaces;

namespace BankingAPI.Modules.Banking.Logic.Services
{
    public class CustomerService: ICustomerService
    {
        // Variable para almacenar la unidad de trabajo
        protected readonly IUoWConfig _uoWConfig;

        // Constructor para llamar la unidad de trabajo y almacenarlo en la variable
        public CustomerService(IUoWConfig uoWConfig)
        {
            _uoWConfig = uoWConfig;
        }

        /// <summary>
        /// Metodo asincronico para agregar datos del cliente en el request DTO
        /// y mandarlo al repositorio AddCustomer y retornarlo en el response
        /// </summary>
        /// <param name="customerRequest"></param>
        /// <returns></returns>
        public async Task<CustomerResponse> Create(CustomerRequest customerRequest)
        {
            var customer = await _uoWConfig.CustomerRepository.AddCustomer(
                new CustomerModel()
                {
                    FirstName   = customerRequest.FirstName,
                    LastName    = customerRequest.LastName,
                    Phone       = customerRequest.Phone,
                    BirthDate   = customerRequest.BirthDate,
                    Address     = customerRequest.Address,
                    Email       = customerRequest.Email,
                    Password    = customerRequest.Password,
                    CreatedAt   = customerRequest.CreatedAt
                });

            await _uoWConfig.CommitAsync();

            return new CustomerResponse(customer.FirstName, customer.LastName, customer.Phone,
                    customer.BirthDate, customer.Address, customer.Email, customer.Password, customer.CreatedAt                
                );
        }

        /// <summary>
        /// Metodo asincronico para almacenar los datos del cliente en el response DTO
        /// y mandarlo al repositorio GetAllCustomer
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CustomerResponse>> GetAll()
        {
            var customers = await _uoWConfig.CustomerRepository.GetAllCustomer();

            return customers.Select(
                    c => new CustomerResponse(c.FirstName, c.LastName, c.Phone, c.BirthDate,
                        c.Address, c.Email, c.Password, c.CreatedAt)
                );
        }

        /// <summary>
        /// Metodo asincronico para almacenar una informacion del cliente en el response DTO
        /// y mandarlo al repositorio GetCustomerById      
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<CustomerResponse> GetById(int id)
        {
            var customer = await _uoWConfig.CustomerRepository.GetCustomerById(id);

            return new CustomerResponse(customer.FirstName, customer.LastName, customer.Phone,
                    customer.BirthDate, customer.Address, customer.Email, customer.Password,
                    customer.CreatedAt
                );
        }

        /// <summary>
        /// Metodo asincronico para agregar un dato del cliente en el request DTO
        /// y mandarlo al repositorio UpdateCustomer y retornarlo en el response
        /// </summary>
        /// <param name="id"></param>
        /// <param name="customerRequest"></param>
        /// <returns></returns>
        public async Task<CustomerResponse> Update(int id, CustomerRequest customerRequest)
        {
            var customer = await _uoWConfig.CustomerRepository.GetCustomerById(id);

            customer.FirstName  = customerRequest.FirstName;
            customer.LastName   = customerRequest.LastName;
            customer.Phone      = customerRequest.Phone;
            customer.BirthDate  = customerRequest.BirthDate;
            customer.Address    = customerRequest.Address;
            customer.Email      = customerRequest.Email;
            customer.Password   = customerRequest.Password;
            customer.CreatedAt  = customerRequest.CreatedAt;

            var customerUpdate = await _uoWConfig.CustomerRepository.UpdateCustomer(customer);

            return new CustomerResponse(customer.FirstName, customer.LastName, customer.Phone,
                      customer.BirthDate, customer.Address, customer.Email, customer.Password,
                      customer.CreatedAt
                  );
        }

        /// <summary>
        /// Metodo asincronico para pasar una infromacion del cliente y 
        /// mandarlo al repositorio DeleteCustomer
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Delete(int id)
        {
            var customer = await _uoWConfig.CustomerRepository.GetCustomerById(id);

            await _uoWConfig.CustomerRepository.DeleteCustomer(customer);
        }
    }
}
