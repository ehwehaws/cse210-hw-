public class Product
{
    private string name;
    private string id;
    private double price;
    private int qty;


    public Product(string name, string id, double price, int qty)
    {
        _name = name;
        _id = id;
        _price = price;
        _qty = qty;
    }

    public double GetTotalPrice()
    {
        return _price * _qty;
    }

    public string GetName() { return _name; }
    public string GetId() { return _id; }
}