public class Customer
{
    private string _name;
    private Address _addr;

    public Customer(string name, Address addr)
    {
        _name = name;
        _addr = addr;
    }

    public string GetName() { return _name; }
    public Address GetAddr() { return _addr; }
}