public class Customer
{
    // Customer specifications
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    
    // Constructor method
    public Customer(int id, string name, string lastName)
    {
        Id = id;
        Name = name;
        LastName = lastName;
    }
}
