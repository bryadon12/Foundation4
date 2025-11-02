
using System.Dynamic;
using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public void setName(string name)
    {
        _name = name;
    }

    public string getName()
    {
        return _name;
    }

    public void setAddress(Address address)
    {
        _address = address;
    }

    public Address getAddress()
    {
        return _address;
    }
    
    public bool inUSA()
    {
        return _address.isUSA();
    }
}