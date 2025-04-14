// written by Chloe Jensrud
// 4/14/2025

namespace FindPivotIndex
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution aSolution = new Solution();
            int[] nums = {2,1,-1};
            int result = aSolution.PivotIndex(nums);

            Console.WriteLine(result);
        }
    }
}
