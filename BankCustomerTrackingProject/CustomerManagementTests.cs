using Xunit;
using BankCustomerTracking;

// Test sınıfı, BankCustomerManager sınıfındaki AddCustomer ve DeleteCustomer metodlarını test eder.
namespace BankCustomerTracking.Tests
{
    public class CustomerManagementTests
    {
        // AddCustomer metodunun doğru çalışıp çalışmadığını kontrol eder.
        [Fact]
        public void AddCustomer_ShouldIncreaseCustomerCount()
        {
            // Arrange: Test için gerekli değişkenlerin hazırlanması.
            var customerManager = new BankCustomerManager(); // BankCustomerManager sınıfı örneği oluşturulur.
            var initialCount = customerManager.ListCustomers().Count; // Müşteri sayısı, metod çağrılmadan önce sayılır.
            var customer = new Customer(1, "Erdal", "Yayla"); // Test için kullanılacak örnek müşteri oluşturulur.

            // Act: Metodun çalıştırılması.
            customerManager.AddCustomer(customer); // Müşteri eklenir.

            // Assert: Beklenen sonucun doğru olup olmadığının kontrolü.
            var actualCount = customerManager.ListCustomers().Count; // Yeni müşteri sayısı sayılır.
            Assert.Equal(initialCount + 1, actualCount); // Yeni müşteri sayısının, önceki müşteri sayısına 1 eklenmiş haline eşit olup olmadığı kontrol edilir.
        }

        // DeleteCustomer metodunun doğru çalışıp çalışmadığını kontrol eder.
        [Fact]
        public void DeleteCustomer_ShouldDecreaseCustomerCount()
        {
            // Arrange: Test için gerekli değişkenlerin hazırlanması.
            var customerManager = new BankCustomerManager(); // BankCustomerManager sınıfı örneği oluşturulur.
            var customer = new Customer(1, "Erdal", "Yayla"); // Test için kullanılacak örnek müşteri oluşturulur.
            customerManager.AddCustomer(customer); // Müşteri eklenir.
            var initialCount = customerManager.ListCustomers().Count; // Müşteri sayısı, metod çağrılmadan önce sayılır.

            // Act: Metodun çalıştırılması.
            customerManager.DeleteCustomer(1); // Müşteri silinir.

            // Assert: Beklenen sonucun doğru olup olmadığının kontrolü.
            var actualCount = customerManager.ListCustomers().Count; // Yeni müşteri sayısı sayılır.
            Assert.Equal(initialCount - 1, actualCount); // Yeni müşteri sayısının, önceki müşteri sayısından 1 çıkarılmış haline eşit olup olmadığı kontrol edilir.
        }
    }
}
