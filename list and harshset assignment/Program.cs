using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace list_and_harshset_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarr = new int[100000];
            Stopwatch dent = new Stopwatch();
            Random roller = new Random();
            List<int> somelist = new List<int>();
            HashSet<int> someSet = new HashSet<int>();
            dent.Start();
            for (var i = 0; i < 100000; i++)
            {
                int Try = (int)(roller.Next(1000, 10000));
                myarr[i]= Try;
            }
            dent.Stop();
            Console.WriteLine(somelist[1001]);
            Console.WriteLine("you spent {0}", dent.ElapsedMilliseconds);
            Console.ReadLine();
            dent.Start();
            for (var i = 0; i < 100000; i++)
            {
                int Try = (int)(roller.Next(1000, 10000));
                somelist.Add(myarr[i]);
                someSet.Add(myarr[i]);
            }
            dent.Stop();
            Console.WriteLine("you spent {0}", dent.ElapsedMilliseconds);
            Console.ReadLine();
            int r = 0;
            dent.Start();
            for (int i = 0; i < 1000; i++)
            {
                if (somelist[i] < 5000)
                {
                    Console.WriteLine(somelist[i]);
                }
            }
            dent.Stop();
            Console.WriteLine("you spent {0}", dent.ElapsedMilliseconds);
            Console.ReadLine();
            dent.Start();
            foreach (int i in someSet)
            {
                if (someSet.Contains(i))
                {
                    r++;
                    if (r <= 1000)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            dent.Stop();
            Console.WriteLine("you spent {0}", dent.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
