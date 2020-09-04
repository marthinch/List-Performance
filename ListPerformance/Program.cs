using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace ListPerformance
{
    class Program
    {
        static int Size = 10;

        static void Main(string[] args)
        {
            ListDynamicCapacity();

            ListPlannedCapacity();
        }

        static void ListDynamicCapacity()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            List<int> list = new List<int>();
            for (int i = 0; i < Size; i++)
            {
                list.Add(i);
            }

            stopwatch.Stop();
            Console.WriteLine("End ListDynamicCapacity : {0}", stopwatch.Elapsed.TotalMilliseconds);
        }

        static void ListPlannedCapacity()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            List<int> list = new List<int>(Size);
            for (int i = 0; i < 1; i++)
            {
                list.Add(i);
            }

            stopwatch.Stop();
            Console.WriteLine("End ListPlannedCapacity : {0}", stopwatch.Elapsed.TotalMilliseconds);
        }
    }
}
