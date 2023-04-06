public class Customer
{
    // Müşteri özellikleri
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    
    // Constructor (yapıcı) metot
    public Customer(int id, string name, string lastName)
    {
        Id = id;
        Name = name;
        LastName = lastName;
    }
}
