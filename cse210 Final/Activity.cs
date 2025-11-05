public class Activity
{
    private string _date;
    private int _duration;
    private string _activity;


    public Activity(string date, string duration, string activity)
    {
        _date = date;
        _duration = duration;
        _activity = activity;
    }

    public virtual double GetDistance()
    {

    }

    public double GetSpeed()
    {
        return GetDistance() / _duration*60;
    }
    
    public double GetPace()
    {
        _duration / GetDistance();
    }
}