// written by Chloe Jensrud
// 4/14/2025

using System.Diagnostics.Metrics;

namespace RecentCalls
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution aSolution = new Solution();


            Console.WriteLine(aSolution.Ping(1));
            Console.WriteLine(aSolution.Ping(100));
            Console.WriteLine(aSolution.Ping(3001));
            Console.WriteLine(aSolution.Ping(3002));
        }
    }
}
