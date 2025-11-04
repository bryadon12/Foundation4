
public class Product
{
    private string _name;
    private int _productID;
    private double _unitPrice;
    private int _quantity;

    public Product(string name, int productID, double unitPrice, int quantity)
    {
        _name = name;
        _productID = productID;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetProductID(int productID)
    {
        _productID = productID;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public void SetUnitPrice(double unitPrice)
    {
        _unitPrice = unitPrice;
    }

    public double GetUnitPrice()
    {
        return _unitPrice;
    }

    public void Setquantity(int quantity)
    {
        _quantity = quantity;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetCost()
    {
        return _unitPrice * _quantity;
    }
}



