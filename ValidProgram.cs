// written by Chloe Jensrud
// 4/14/2025

namespace ValidParentheses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution aSolution = new Solution();

            Console.WriteLine(aSolution.IsValid("()"));
            Console.WriteLine(aSolution.IsValid("{})"));
            Console.WriteLine(aSolution.IsValid("{]"));
            Console.WriteLine(aSolution.IsValid("(){}[]"));
        }
    }
}
