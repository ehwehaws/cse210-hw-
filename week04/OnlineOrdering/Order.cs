using System.Numerics;

public class Order
{
    private List<Product> _items = new List<Product>();
    private Customer _cust;

    public Order(Customer cust) {
        _cust = cust;
    }

    public void AddItem(Product p) {
        _items.Add(p);
    }

    public double GetTotal() {
        double total = 0;
        foreach (Product p in _items)
        {
            total += p.GetTotalPrice();
        }
        if (_cust.GetAddr().InUsa())
        { total += 5; }
        else
        { total += 35; }
        return total;
    }

    public string GetPackingLabel() {
        string txt = "Packing Label:\n";
        foreach (Product p in _items)
        {
            txt += p.GetName() + " (" + p.GetId() + ")\n";
        }
        return txt;
    }

    public string GetShippingLabel() {
        return "Ship To: " + _cust.GetName() + "\n" + _cust.GetAddr().GetFull();
    }




}