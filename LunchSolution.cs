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
            int student = queue.Dequeue();

            if(student == sandwiches[sandwichIndex])
            {
                sandwichIndex++;
                reset = 0;
            }
            else
            {
                queue.Enqueue(student);
                reset++;
            }
        }
        return studentLine.Count;
    }
}
    }
}
