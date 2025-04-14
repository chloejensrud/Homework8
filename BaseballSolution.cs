// written by Chloe Jensrud
// 4/14/2025

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    public class Solution
    {
        public int KeepScore(string[] operations)
        { 
            Stack<int> plays = new Stack<int>();

            foreach(string o in operations)
            {
                if(o == "+")
                {
                    int top = plays.Pop();
                    int newTop = top + plays.Peek();

                    plays.Push(top);
                    plays.Push(newTop);
                }
                else if(o == "D")
                {
                    plays.Push(2 * plays.Peek());
                }
                else if(o == "C")
                {
                    plays.Pop();
                }
                else
                {
                    plays.Push(int.Parse(o));
                }
            }
            int total = 0; 
            foreach(int score in plays)
            {
                total += score;
            }
            return total;
        }
    }
}
