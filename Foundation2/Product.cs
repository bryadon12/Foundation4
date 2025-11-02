using System.Dynamic;
using System.IO.Compression;

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

    public void setName(string name)
    {
        _name = name;
    }

    public string getName()
    {
        return _name;
    }

    public void setProductID(int productID)
    {
        _productID = productID;
    }

    public int getProductID()
    {
        return _productID;
    }

    public void setUnitPrice(float unitPrice)
    {
        _unitPrice = unitPrice;
    }

    public float getUnitPrice()
    {
        return _unitPrice;
    }

    public void setquantity(int quantity)
    {
        _quantity = quantity;
    }

    public int getQuantity()
    {
        return _quantity;
    }

    public float getCost()
    {
        return _unitPrice * _quantity;
    }
}



