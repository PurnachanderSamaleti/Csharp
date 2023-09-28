using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class Program5
    {
        public static void Main(String[] args)
        {
            String[] a = { "Hello", "Hai", "How", "Why" };
            int[] b = { 1, 2, 3, 4, 5, 6, 7 };

            //String[] chandu = new String[5];

            //another way for declaration of array values
            String[] a1 = new String[4];
            a1[0] = "Hellooo";
            a1[1] = "Hai";
            a1[2] = "How";
            a1[3] = "Why";
            Console.WriteLine(a[0]);
            Console.WriteLine(a1[0]);

            for (int i = 0; i < a.Length; i++) {

                Console.WriteLine(a[i]);
                if (a[i] == "Hai")
                {
                    Console.WriteLine("Match found");
                }
                    }
                
        }
    }
}