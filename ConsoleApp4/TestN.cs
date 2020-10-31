using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class TestN
    {
        public static void TestT()
        {

            Console.WriteLine("Do you want to continue give yes");
            string con = Console.ReadLine();
            if (con.Equals("yes"))
            {
                logic();
            }


        }

        public static void logic()

        {
            Console.WriteLine("Enter any number between 100");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i < 50)
            {
                Console.WriteLine("You are failed");
            }

            else
            {
                Console.WriteLine("You are passed");
            }

        }
    }
}
