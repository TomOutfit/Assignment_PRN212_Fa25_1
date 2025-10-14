using FUMiniHotelSystem.DataAccess.Interfaces;
using FUMiniHotelSystem.Models;

namespace FUMiniHotelSystem.DataAccess
{
    public class CustomerRepository : JsonRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository() : base("customers.json") { }

        public async Task<Customer?> GetByEmailAsync(string email)
        {
            var customers = await GetAllAsync();
            return customers.FirstOrDefault(c => c.EmailAddress.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<List<Customer>> GetActiveCustomersAsync()
        {
            var customers = await GetAllAsync();
            return customers.Where(c => c.CustomerStatus == 1).ToList();
        }
    }
}
