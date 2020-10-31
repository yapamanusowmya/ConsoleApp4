using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class SpaceUnderscore
    {
        public static void UnderScore()
        {
            string stmt = "I have a string which should replace space with underscore";
            int len = stmt.Length;
            char[] ch = stmt.ToCharArray();
            string temp = null;

            for (int i=0;i<len;i++)
            {
                
                if (ch[i]==' ')
                {

                    string temph= ch[i + 1].ToString().ToUpper();
                    temp = temp +"_"+ temph;
                    i++;

                }
                else
                {
                    temp = temp + ch[i].ToString();
                }

            }
            Console.WriteLine(temp);
            Console.Read();
        }
    }
}
