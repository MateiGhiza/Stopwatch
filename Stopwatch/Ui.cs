namespace Stopwatch;

public class Ui
{
    public void uI(string input)
    {
            
        var stopwatch = new Stopwatch();
        bool isRunning = false;
        bool isStarted = false;


        while (input.ToLower() != "exit")
        {

            if (input.ToLower() == "start")
            {

                if (isRunning)
                {
                    throw new InvalidOperationException("You can't start the timer once it has been stated");
                }
                else
                {
                    stopwatch.Start();
                    isRunning = true;
                    isStarted = true;
                    input = Console.ReadLine();
                }
            }
            else if (input.ToLower() == "stop")
            {
                if (isStarted)
                {
                    stopwatch.Stop();
                    isRunning = false;

                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You need to start the stopwatch ,scrie start wai");
                    input = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("ce cuvinte este astea");
                input = Console.ReadLine();
            }


        }


    }  
}