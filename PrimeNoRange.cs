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
            int num, i, ctr, s1, s2;

            Console.Write("Find the prime numbers within a range of numbers:\n");
            Console.WriteLine("---------------------------------------------------");
            Console.Write("Input starting number of range: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", s1, s2);

            for (num = s1; num <= s2; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");
        }
    }
}
