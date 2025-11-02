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
        _state = state;S
        _country = country;
    }

    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetCountry(string country)
    {
        _country = coutry;
    }

    public string GetCountry()
    {
        return _country;
    }

    public bool IsUSA()
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

    public string GetAddress()
    {
        return $"{_streetAddress} {_city} {_state} {_country}";
    }
}
