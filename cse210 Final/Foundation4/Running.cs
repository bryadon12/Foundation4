public class Running : Activity
{
    private double _distance;

    public Running(string date, string duration, string activity, double distance) : base(date, duration, activity)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
}