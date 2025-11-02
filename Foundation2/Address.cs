using System.Runtime.CompilerServices;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public void setStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public string getStreetAddress()
    {
        return _streetAddress;
    }

    public void setCity(string city)
    {
        _city = city;
    }

    public string getCity()
    {
        return _city;
    }

    public void setState(string state)
    {
        _state = state;
    }

    public string getState()
    {
        return _state;
    }

    public void setCountry(string country)
    {
        _country = coutry;
    }

    public string getCountry()
    {
        return _country;
    }

    public bool isUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string getAddress()
    {
        return $"{_streetAddress} {_city} {_state} {_country}";
    }
}
