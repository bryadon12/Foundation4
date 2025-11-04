public class Reception : Event
{
    private string _email;

    public LectuReceptionre(string title, string description, string time, Address address, string type, string email) : base(title, description, time, address, type)
    {
        _email = email;
    }

    public string FullDetails()
    {
        return $"{Details()}\nRSVP to {_email}";
    }
}