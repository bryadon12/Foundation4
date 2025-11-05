

public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, string duration, string activity, int numberOfLaps) : base(date, duration, activity)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50;
    }
}