using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
        public class Program2 : Program4
    {
        string name;
        string lastname;
        public Program2(string name1) 
        {
            this.name = name1;
        }
        public Program2(String name, String lastname)
        {
            this.name = lastname;
        }
        public void getname()
        {
            Console.WriteLine("My name is " +this.name);
                }

        public void getdata()
        {
            Console.WriteLine("I am in second program");
        }
        public static void Main(string[] args)
        {
            Program2 p2 = new Program2("Chander");
            Program2 p = new Program2("Purna","Chander");
            p.getdata();
            p2.getdata();

            //Program31 p3 = new Program31();
            //p3.setdata();
            //Program4 p4 = new Program4();
            //p4.calldata();
            p2.calldata();
            p2.getname();
            int a = 25;
            Console.WriteLine("Number is " + a);
            string name = "chandu";
            Console.WriteLine("Name is " + name);
            var name1 = ("Chandu1");
            Console.WriteLine("Name1 is " + name1);
            dynamic name2 = "Chandu2";
            Console.WriteLine("Name 2 is " + name2);
            dynamic number = 65;
            Console.WriteLine("Number " + number);

        }
    }
}
