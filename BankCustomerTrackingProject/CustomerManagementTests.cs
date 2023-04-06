using Xunit;
using BankCustomerTracking;

// Test classes, Tests the AddCustomer and DeleteCustomer methods in the BankCustomerManager class.
namespace BankCustomerTracking.Tests
{
    public class CustomerManagementTests
    {
        // Checks if the Add Customer method is working correctly.
        [Fact]
        public void AddCustomer_ShouldIncreaseCustomerCount()
        {
            // Arrange: Preparation of variables required for testing.
            var customerManager = new BankCustomerManager(); // An instance of the Bank Customer Manager class is created.
            var initialCount = customerManager.ListCustomers().Count; //Customer count is counted before the method is called.
            var customer = new Customer(1, "Erdal", "Yayla"); // A sample client to be used for testing is created.

            // Act: running the method.
            customerManager.AddCustomer(customer); // Customer adds.

            // Assert: Checking if the expected result is correct.
            var actualCount = customerManager.ListCustomers().Count; // Number of new customers counted.
            Assert.Equal(initialCount + 1, actualCount); // It is checked whether the number of new customers is equal to the number of previous customers with 1 added..
        }

        // Checks if the Delete Customer method is working correctly.
        [Fact]
        public void DeleteCustomer_ShouldDecreaseCustomerCount()
        {
            // Arrange: Preparation of variables required for testing.
            var customerManager = new BankCustomerManager(); // An instance of the Bank Customer Manager class is created.
            var customer = new Customer(1, "Erdal", "Yayla"); //  A sample customer to be used for testing is created
            customerManager.AddCustomer(customer); // Customer is added.
            var initialCount = customerManager.ListCustomers().Count; // The number of clients is counted before the method is called.

            // Act: Running the method.
            customerManager.DeleteCustomer(1); // Customer deleted.

            // Assert: Checking whether the expected result is correct.
            var actualCount = customerManager.ListCustomers().Count; // Number of new customers counted.
            Assert.Equal(initialCount - 1, actualCount); //It is checked whether the number of new customers equals 1 less than the previous number of customers.
        }
    }
}
