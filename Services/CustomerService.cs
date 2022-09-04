using Models;
using Blazored.LocalStorage;
using System.Text.Json;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ILocalStorageService localStorageService;
        public CustomerService(ILocalStorageService localStorageService)
        {
            this.localStorageService = localStorageService;
        }

        private string customersLocalStorageKey = "customerKey";

        public async Task<List<Customer>> GetCustomers()
        {
            var customersJson = await localStorageService.GetItemAsync<string>(customersLocalStorageKey);
            if (string.IsNullOrEmpty(customersJson))
                return new List<Customer>();
            return JsonSerializer.Deserialize<List<Customer>>(customersJson);
        }
        public async Task SaveCustomers(List<Customer> custumers)
        {
            var customersJson = JsonSerializer.Serialize(custumers);
            await localStorageService.SetItemAsync(customersLocalStorageKey, customersJson);
        }
    }
}
