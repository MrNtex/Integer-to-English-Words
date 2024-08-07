using System;
using System.Collections.Generic;


public class Program
{
    const bool longScale = false;
    public static void Main()
    {
        Program p = new Program();
        Console.WriteLine(p.NumberToWords(62326235287421129));
    }

    Dictionary<int, string> units = new Dictionary<int, string>()
    {
        {1, "One"},
        {2, "Two"},
        {3, "Three"},
        {4, "Four"},
        {5, "Five"},
        {6, "Six"},
        {7, "Seven"},
        {8, "Eight"},
        {9, "Nine"},
    };
    Dictionary<int, string> decimals = new Dictionary<int, string>(){
        {2, "Twenty"},
        {3, "Thirty"},
        {4, "Forty"},
        {5, "Fifty"},
        {6, "Sixty"},
        {7, "Seventy"},
        {8, "Eighty"},
        {9, "Ninety"},
    };
    Dictionary<int, string> teens = new Dictionary<int, string>(){
        {0, "Ten"},
        {1, "Eleven"},
        {2, "Twelve"},
        {3, "Thirteen"},
        {4, "Fourteen"},
        {5, "Fifteen"},
        {6, "Sixteen"},
        {7, "Seventeen"},
        {8, "Eighteen"},
        {9, "Nineteen"},
    };
    Dictionary<int, string> powersSL = new Dictionary<int, string>(){
        {1, "Thousand"},
        {2, "Million"},
        {3, "Billion"},
        {4, "Trillion"},
        {5, "Quadrillion"},
        {6, "Quintillion"},
        {7, "Sextillion"},
        {8, "Septillion"},
        {9, "Octillion"}
    };

    Dictionary<int, string> powersLL = new Dictionary<int, string>(){
        {1, "Thousand"},
        {2, "Million"},
        {3, "Milliard"},
        {4, "Billion"},
        {5, "Billiard"},
        {6, "Trillion"},
        {7, "Trilliard"},
        {8, "Quadrillion"},
        {9, "Quadrilliard"}
    };
    public string NumberToWords(long num)
    {
        if (num == 0) return "Zero";

        string s = num.ToString();

        string group = "";
        int power = 0;

        Stack<string> result = new Stack<string>();

        for (int i = s.Length - 1; i >= 0; i--)
        {

            group += s[i];

            if (group.Length == 3)
            {
                CreateText(ref group, ref power, result);
            }
        }

        CreateText(ref group, ref power, result);

        return string.Join(" ", result);
    }

    private void CreateText(ref string group, ref int power, Stack<string> result)
    {
        if (group == "") return;
        if (group == "000")
        {
            power++;
            group = "";
            return;
        }

        

        if (power > 0) result.Push(longScale ? powersLL[power] : powersSL[power]);

        if (group.Length >= 2 && group[1] == '1')
        {
            result.Push(teens[group[0] - '0']);
        }
        else
        {
            if (group[0] != '0') result.Push(units[group[0] - '0']);
            if (group.Length >= 2 && group[1] != '0') result.Push(decimals[group[1] - '0']);
        }

        if (group.Length >= 3 && group[2] != '0')
        {
            result.Push("Hundred");
            result.Push(units[group[2] - '0']);
        }

        power++;
        group = "";
    }
}