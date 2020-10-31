using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class test
    {
        public static void stest()
        {
            string s = "my name is \"sowmya yap\" \"Yapamanu kutty tina so\" add remove \"cal sub div\"";
            bool f = false;
            string[] d = s.Split(' ');
            foreach (string str in d)
            {
                if (!(str.Contains("\"")) && f)
                {
                    Console.Write(str + " ");
                }
                if (str.Contains("\"") || f)
                {
                    char[] c = str.ToCharArray();
                    if (c[0] == ('\"'))
                    {
                        Console.Write(str + " ");
                        f = true;
                    }
                    else if (c[str.Length - 1] == '\"')
                    {
                        Console.WriteLine(str);
                        f = false;
                    }
                }
                else
                    Console.WriteLine(str);
            }
        }
    }
}
