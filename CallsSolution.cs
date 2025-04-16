﻿// written by Chloe Jensrud
// 4/14/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RecentCalls
{
    public class RecentCounter
    {
        private Queue<int> queue;

        public RecentCounter()
        {
            queue = new Queue<int>();
        }
        public int Ping(int t)
        {
            queue.Enqueue(t);

            while(queue.Peek() < t - 3000)
            {
                queue.Dequeue();
            }
            return queue.Count;
        }
    }
}
