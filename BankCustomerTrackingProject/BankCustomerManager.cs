using System.Collections.Generic;
using System.Linq;

namespace BankCustomerTracking
{
    // Müşteri yönetim işlemlerini gerçekleştiren sınıf
    public class BankCustomerManager : ICustomerManagement
    {
        private List<Customer> _customers; // Müşteri listesi

        // Yapıcı metot, müşteri listesini başlatır
        public BankCustomerManager()
        {
            _customers = new List<Customer>();
        }

        // Yeni müşteri ekler
        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        // Müşteri siler
        public void DeleteCustomer(int id)
        {
            // Verilen id'ye sahip müşteriyi bulur
            var customer = _customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                _customers.Remove(customer); // Müşteriyi listeden siler
            }
        }

        // Tüm müşterileri listeler
        public List<Customer> ListCustomers()
        {
            return _customers;
        }
    }
}