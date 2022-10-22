using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmProblem
{
    public class BubbleSort
    {
        public void Bubble()
        {
            int[] arr = { 78, 55, 45, 13 };
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("sorted:");
            foreach (int p in arr)
            {
                Console.WriteLine(p + "");
            }

        }
    }
}
