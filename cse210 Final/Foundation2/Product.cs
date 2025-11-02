
public class Product
{
    private string _name;
    private int _productID;
    private float _unitPrice;
    private int _quantity;

    public Product(string name, int productID, float unitPrice, int quantity)
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

    public void SetUnitPrice(float unitPrice)
    {
        _unitPrice = unitPrice;
    }

    public float GetUnitPrice()
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

    public float GetCost()
    {
        return _unitPrice * _quantity;
    }
}



