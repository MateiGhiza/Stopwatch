using System.Threading.Channels;

namespace Stopwatch;

public class Stopwatch
{
    DateTime startTime,endTime;

    public void Start()
    {
        startTime=DateTime.Now;
        Console.WriteLine("a");
        
    }

    public void Stop()
    {
        endTime=DateTime.Now;
        TimeSpan time = endTime - startTime;
        Console.WriteLine("The following "+time+" has passed");
    }
}