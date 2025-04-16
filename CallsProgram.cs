// written by Chloe Jensrud
// 4/14/2025

using System.Diagnostics.Metrics;

namespace RecentCalls
{
    public class Program
    {
        static void Main(string[] args)
        {
            RecentCounter count = new RecentCouter();


            Console.WriteLine(count.Ping(1));
            Console.WriteLine(count.Ping(100));
            Console.WriteLine(count.Ping(3001));
            Console.WriteLine(count.Ping(3002));
        }
    }
}
