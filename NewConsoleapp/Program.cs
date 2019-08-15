using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewConsoleapp
{
    public class Program
    {
        public static int LeastFrequent(int[] a)
        {
            int value = 0;
            for (int i = 0; i < a.Length; i++)
                value = value ^ a[i];
            return value;

        }

        public static void Main(string[] args)
        {
            int[] a = new int[] { 1, 4, 2, 1, 3,3, 4, 2,7};
            int once = LeastFrequent(a);

            Console.WriteLine("Value that appears once is {0}.", once);
            Console.WriteLine(HasDuplicates(a));
            Console.ReadLine();
        }

        public static bool HasDuplicates(int[] a)
        {
         
            for (int i = 0; i < a.Length; i++)
            {
                for (int x = i + 1; x < a.Length; x++)
                {
                    if (a[i] == a[x]) return true;
                }
            }
            return false;
            
        }
       

    }
}
