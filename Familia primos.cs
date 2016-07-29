using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primos = new List<int>();
            Console.WriteLine("Até que número você gostaria de saber quais são os primos?");
            int qnts = int.Parse(Console.ReadLine()); 

            for (int i = 2; i<qnts; i++)
            {
                primos.Add(i);               
            }

            for (int i = 0; i < primos.Count; i++)
            {
                if (i > 1 && primos.Contains(i))
                {
                    for( int v = i; v<primos.Count; v++)
                    {
                        primos.Remove(v * i);
                    }
                }
            }

            for (int i = 0; i < primos.Count; i++)
            {
                Console.WriteLine("O " + (i+1) + "º número primo é " + primos[i]);
            }
               
            Console.ReadLine();
        }
    }
}
