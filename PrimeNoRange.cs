using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmProblem
{
    public class PrimeNoRange
    {
       public void CheckPrime()
        {
            int j, i, count, s1, s2;

            Console.Write("Find the Prime numbers within a range of numbers:\n");
            Console.WriteLine("---------------------------------------------------");
            Console.Write("Input starting number of range: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", s1, s2);

            for (j = s1; j <= s2; j++)
            {
                count = 0;

                for (i = 2; i <= j / 2; i++)
                {
                    if (j % i == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && j != 1)
                    Console.Write("{0} ", j);
            }
            Console.Write("\n");
        }
    }
}
