using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class HETestHighestDiff
    {
        static List<int> px = new List<int>();

        static List<int> pxValue = new List<int>();

        public static void readlist()
        {
            Console.WriteLine("Enter 6 numbers");
            for (int i = 0;i<6;i++)
            {
                px.Add(Convert.ToInt32 (Console.ReadLine()));

            }
            int len = px.Count;

            for(int i=1;i<len;i++)
            {
                for(int j=0;j<i;j++)
                {
                    if(px[i]>px[j])
                    {
                        pxValue.Add(px[i] - px[j]);

                    }
                }
            }
            int highestValue = pxValue.Max();
            Console.WriteLine("The number is "+highestValue);
            Console.ReadLine();
        }
    }
}
