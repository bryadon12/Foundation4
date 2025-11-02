
using System.Net.Http.Headers;
using System.Numerics;

public class Order
{
    private Customer _customer;
    private List<Product> _pruducts;


    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float ClculateCost()
    {
        float cost = 0;
        foreach (Product product in _products)
        {
            cost += product.GetCost();
        }
        return cost;
    }

    public string PackingLable()
    {
        string packingLable;
        foreach (Product product in _products)
        {
            packingLable = $"{packingLable} {product.GetName()}: {product.GetProductID()}\n";
        }

        return packingLable;
    }

    public string ShippingLable()
    {
        return $"{_customer.GetName()}: {_customer.GetAddress()}";
    }
}