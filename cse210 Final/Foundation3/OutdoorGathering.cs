public class OutdoorGathering : Event
{
    private string _statementOfWeather;

    public OutdoorGathering(string title, string description, string time, Address address, string type, string statementOfWeather) : base(title, description, time, address, type)
    {
        _statementOfWeather = statementOfWeather;
    }

    public string FullDetails()
    {
        return $"{Details()}\n{_statementOWeather}";
    }
}