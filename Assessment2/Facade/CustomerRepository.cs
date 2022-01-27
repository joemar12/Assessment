using System.Collections.Generic;
using System.Linq;

namespace Assessment2.Facade
{
    public class CustomerRepository
    {
        private List<Customer> _customers;
        public CustomerRepository()
        {
            _customers = new List<Customer>()
            {
                new Customer()
                {
                    Id = 1, Name = "Customer 1", 
                    Subscription = new Subscription() { Id = 1, IsActive = false }
                }

            };
        }
        public Customer GetCustomer(int id)
        {
            return _customers.Where(x => x.Id == id).FirstOrDefault();
        }
        public bool UpdateCustomer(Customer customer)
        {
            var index = _customers.FindIndex(x => x.Id == customer.Id);
            _customers[index] = customer;
            return true;
        }
    }
}
