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
            Stack<int> record = new Stack<int>();

            foreach(string o in operations)
            {
                if(o == "+")
                {
                    int top = record.Pop();
                    int newTop = top + record.Peek();

                    record.Push(top);
                    record.Push(newTop);
                }
                else if(o == "D")
                {
                    record.Push(2 * plays.Peek());
                }
                else if(o == "C")
                {
                    record.Pop();
                }
                else
                {
                    record.Push(int.Parse(o));
                }
            }
            int total = 0; 
            foreach(int score in record)
            {
                total += score;
            }
            return total;
        }
    }
}
