// written by Chloe Jensrud
// 4/14/2025


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoLunch
{
    public class Solution
    {
        public int StudentCount(int[] students, int[] sandwiches)
        {
            Queue<int> studentLine = new Queue<int>(students);
            int sandwichIndex = 0;
            int reset = 0; 

            while(studentLine.Count > 0 && reset < studentLine.Count)
            {
                if(studentLine.Peek() == sandwiches[sandwichIndex])
                {
                    studentLine.Dequeue();
                    sandwichIndex++;
                    reset = 0;
                }
                else
                {
                    studentLine.Enqueue(studentLine.Dequeue());
                    reset++;
                }
            }
            return studentLine.Count;
        }
    }
}
