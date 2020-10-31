using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //SpaceUnderscore.UnderScore();
            HETestHighestDiff.readlist();
            //TestN.TestT();
            ////test.stest();
            //test1.test2();
            string s = "my name is \"sowmya yap\" \"Yapamanu kutty tina so\" add remove \"cal sub div\"";
            Console.WriteLine(s);
            string stemp = null;
            int i = 0;
            char[] so = s.ToCharArray();
            int len = s.Length;
            bool g = false;
            while (i < len)
            {
                if (so[i] == '\"')
                {
                    if (g)
                    {
                        g = false;
                    }
                    else
                    {
                        g = true;
                    }
                }
                if (so[i] != ' ' || g)
                {
                    stemp = stemp + so[i];
                }
                else if (stemp != null)
                {
                    Console.WriteLine(stemp);
                    stemp = null;
                }
                i++;
            }
            Console.WriteLine(stemp);
        }
    }
}
