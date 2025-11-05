public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, string duration, string activity, double speed) : base(date, duration, activity)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * duration / 60;
    }
}