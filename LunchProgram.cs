// written by Chloe Jensrud
// 4/14/2025

namespace NoLunch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution aSolution = new Solution();
            int[] students = { 1, 1, 1, 0, 0, 1 };
            int[] sandwiches = { 1, 0, 0, 0, 1, 1 };

            Console.WriteLine(aSolution.StudentCount(students, sandwiches));
        }
    }
}
