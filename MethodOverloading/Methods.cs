using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading;
internal class Methods
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static decimal Add(decimal a, decimal b)
    {
        return a + b;
    }

    public static string Add(int a, int b, bool c)
    {
        int sum = a + b;
        if (c == true)
        {
            if (sum == 1) 
            {
                return sum + " Dollar";
            }
            return sum + " Dollars";
           
        }
        else
        {
            return sum.ToString();
        }
    }
}

