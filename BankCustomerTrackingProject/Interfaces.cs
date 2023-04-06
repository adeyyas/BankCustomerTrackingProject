// namespace BankCustomerTracking;
//
// public class CustomerManager
// {
//     public class CustomerManager : ICustomerManagement
//     {
//         private List<Customer> _customers;
//
//         public CustomerManager()
//         {
//             _customers = new List<Customer>();
//         }
//
//         public void AddCustomer(Customer customer)
//         {
//             _customers.Add(customer);
//         }
//
//         public void DeleteCustomer(int id)
//         {
//             var customer = _customers.FirstOrDefault(c => c.Id == id);
//             if (customer != null)
//             {
//                 _customers.Remove(customer);
//             }
//         }
//
//         public List<Customer> ListCustomers()
//         {
//             return _customers;
//         }
//     }
// }