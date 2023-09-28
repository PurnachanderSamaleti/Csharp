using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class Program6
    {
        public static void Main(String[] args)
        {
            String[] chandu = { "123", "456", "789", "987", "654", "321" };

            //another type for declaration of array
            String[] chandu1 = new string[3];
            chandu1[0] = "Ariqt";
            chandu1[1] = "Ariqt1";
            chandu1[2] = "Ariqt2";

            //Console.WriteLine(chandu[2]);
            //Console.WriteLine(chandu1[0]);
            for (int i = 0; i < chandu1.Length; i++)
            {

                {
                    Console.WriteLine(chandu1[i]);
                }
                for (int j = 0; j < chandu1.Length; j++)
                {
                    if (chandu1[i] == "Ariqt14")

                        Console.WriteLine("Match found");
                
                else
                {
                        Console.WriteLine("Match not found");
                }

                    break;

                }
            }
        }
    }
}

