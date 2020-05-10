using System;
using System.Timers;

namespace MyTimer01
{
    class Program
    {
        private static Timer timer;

        static void Main(string[] args)
        {
            timer = new Timer()
            {
                Interval = 1000,
            };
            
            timer.Elapsed += TimerEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
            Console.ReadLine();

           
        }

        static void TimerEvent(object source, System.Timers.ElapsedEventArgs e)
        {
            Console.Clear();
            Console.WriteLine("Test: {0:HH:mm:ss}", e.SignalTime);
            
        }

    }
}
