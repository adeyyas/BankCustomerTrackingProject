using System.Collections.Generic;

namespace BankCustomerTracking
{
    // Müşteri yönetim işlemlerini tanımlayan arayüz
    public interface ICustomerManagement
    {
        // Yeni müşteri ekler
        void AddCustomer(Customer customer);

        // Belirtilen ID'ye sahip müşteriyi siler
        void DeleteCustomer(int id);

        // Tüm müşterileri listeler
        List<Customer> ListCustomers();
    }
}