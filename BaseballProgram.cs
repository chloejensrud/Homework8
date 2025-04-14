// written by Chloe Jensrud
// 4/14/2025

namespace BaseballGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution aSolution = new Solution();
            string[] o = { "5", "2", "C", "D", "+" };
            int result = aSolution.KeepScore(o);

            Console.WriteLine(result);
        }
    }
}
