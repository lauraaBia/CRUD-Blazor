using Models;

namespace Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomers();
        Task SaveCustomers(List<Customer> customers);
    }
}
