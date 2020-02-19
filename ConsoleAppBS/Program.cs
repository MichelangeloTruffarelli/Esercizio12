using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensione = { 1, 20, 50, 100, 500, 1000 };
            using (StreamWriter sw = new StreamWriter("stat.csv", false, Encoding.UTF8))
            {
                sw.WriteLine("Algoritmo, Dimensione, Tipo");
                foreach (int dim in dimensione)
                {
                    int[] numeri = new int[dim];
                    Random random = new Random();
                    for (int i = 0; i < dim; i++)
                        numeri[i] = random.Next();
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    BubbleSort.Sort(numeri);
                    s.Stop();
                    long elapsed = s.ElapsedMilliseconds;
                    sw.WriteLine($"BubbleSort;{dim};{elapsed}");
                }
                sw.Flush();
                Console.ReadLine();
            }
        }
    }
}
