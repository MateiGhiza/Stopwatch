using System.Threading.Channels;

namespace Stopwatch;

public class Stopwatch
{
    DateTime startTime,endTime;

    public void Start()
    {
        startTime=DateTime.Now;
        Console.WriteLine("(test daca intra in start :x)");
        
    }

    public void Stop() 
    { //aici nu mai trebuie test ca daca ajunge in 'stop' ii da out la linia de mai jos pwp
        endTime=DateTime.Now;
        TimeSpan time = endTime - startTime;
        Console.WriteLine("a trecut  atata timp: " +time);
    }
}