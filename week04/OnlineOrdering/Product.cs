public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _qty;


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