using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmProblem
{
    public class Anagramcs
    {
        public void CheckAnagram()
        {
            Console.WriteLine("enter the first string: ");
            //string str1 = "earth";
            //string str2 = "heart";
            string str1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the second string: ");
            string str2 = Convert.ToString(Console.ReadLine());
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);
            string s1 = new string(ch1);
            string s2 = new string(ch2);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            if (s1 == s2)
            {
                Console.WriteLine("anagram");
            }
            else
            {
                Console.WriteLine("not anagram");
            }
        }
    
    }
}
