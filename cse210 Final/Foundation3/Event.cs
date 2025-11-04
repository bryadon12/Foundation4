using System.Net.Sockets;

public class Event
{
    private string _title;
    private string _description;
    private string _time;
    private Address _address;
    private string _type;


    public Event(string title, string description, string time, Address address, string type)
    {
        _title = title;
        _description = description;
        _time = time;
        _address = address;
        _type = type;
    }

    public string StandardDetails()
    {
        return $"{_title}\n{_description}\n{_time}\n{_address}";
    }

    public string ShortDescription()
    {
        return $"{_type}: {_title}\n{_date}";
    }

    public virtual string FullDetails()
    {
        
    }
}
