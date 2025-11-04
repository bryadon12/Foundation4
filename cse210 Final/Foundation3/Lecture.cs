public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string time, Address address, string type, string speaker, int capacity) : base(title, description, time, address, type)
    {
        _capacity = capacity;
        _speaker = speaker;
    }

    public string FullDetails()
    {
        return $"{Details()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}