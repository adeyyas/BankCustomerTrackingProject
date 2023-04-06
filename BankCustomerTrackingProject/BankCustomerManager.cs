using System.Collections.Generic;
using System.Linq;

namespace BankCustomerTracking
{
    // Class performs customer management operations
    public class BankCustomerManager : ICustomerManagement
    {
        private List<Customer> _customers; // Customer list

        // Constructor method, initalize the customer list
        public BankCustomerManager()
        {
            _customers = new List<Customer>();
        }

        // Adds new customer
        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        // Deletes customer
        public void DeleteCustomer(int id)
        {
            // Finds the customer with the given id
            var customer = _customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                _customers.Remove(customer); //Deletes the customer from the list
            }
        }

        // Deletes the all customers from the list
        public List<Customer> ListCustomers()
        {
            return _customers;
        }
    }
}