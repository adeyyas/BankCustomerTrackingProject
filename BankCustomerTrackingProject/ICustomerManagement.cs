using System.Collections.Generic;

namespace BankCustomerTracking
{
    // Interface that defines customer management processes
    public interface ICustomerManagement
    {
        // Customer adds
        void AddCustomer(Customer customer);

        // Deletes the customer with the specified ID
        void DeleteCustomer(int id);

        // Lists all customers
        List<Customer> ListCustomers();
    }
}