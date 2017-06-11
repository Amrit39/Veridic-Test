using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j=0;
            int variable;
            int[] array = { 12, 56, 89, 65, 61, 36, 45, 23 };
            for (i = 0; i < array.Length; i++)
            {
                if (array[i]>j)
                {
                    j = array[i];

                }


            }
            var result = string.Join(",", array);
            Console.WriteLine(result);
            Console.WriteLine("Largest no. is " + j);


            var sortedArray = array.OrderBy(x=>x);
            var result1 = string.Join(",", sortedArray);
            Console.WriteLine("Sorted array is  " + result1);

            for (i = 0; i < array.Length; i++)
            {
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[k] < array[i])
                    {
                        variable = array[i];
                        array[i] = array[k];
                        array[k] = variable;
                    }
                }
            }
            var result2 = string.Join(",", array);
            Console.WriteLine("Sorted array is  " + result2);

            Console.WriteLine("Series Upto 10  ");
            List<int> fabList = new List<int>();
         int   nextTerm, t1=0, t2=1;
            Console.Write(0);
            for (i = 0; i <=10; i++)
            {
                nextTerm = t1 + t2;
                t1 = t2;
                t2 = nextTerm;
                Console.Write(","+nextTerm);
            }
           
            Console.ReadLine();
        }
    }
}
