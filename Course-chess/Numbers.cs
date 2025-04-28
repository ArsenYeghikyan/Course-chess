using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp9;

    internal class Numbers
    {

   public static string CardinalToOrdinal(int number)
    {
        string ordinal = number.ToString();
        char lastChar = ordinal[ordinal.Length - 1];
        switch (lastChar)
        {
            case '1':
                ordinal += "st";
                break;
            case '2':
                ordinal += "nd";
                break;
            case '3':
                ordinal += "rd";
                break;
            default:
                ordinal += "th";
                break;
        }
        return ordinal;
    }

  public static void RunCardinalToOrdinal()
    {
        for (int i = 1; i <= 40; i++)
        {
            Console.WriteLine(CardinalToOrdinal(i));
        }
    }
}

