using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class test1
    {

        public static void test2()
        {
            string s = "my name is \"sowmya yap\" \"Yapamanu kutty tina so\" add remove \"cal sub div\"";
            string stemp = null;
            bool g = false;
           foreach(char ch in s)
            {
                if (ch == '\"')
                {
                    if(g)
                    {
                        g = false;
                    }
                    else
                    {
                        g = true;
                    }
                }
                if (ch != ' ' || g)
                {
                    stemp = stemp + ch;
                }
                else if (stemp != null)
                {
                    Console.WriteLine(stemp);
                    stemp = null;
                }
            }
               
            Console.WriteLine(stemp);

        }
    }
}
