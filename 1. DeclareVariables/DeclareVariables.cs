using System;

class DeclareVariables
{
    static void Main()
    {
        //-10000
        //-115
        //97
        //52130
        //4825932

        short a = -10000;
        sbyte b = -115; 
        byte c = 97; 
        ushort d = 52130;
        int e = 4825932;

        Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|", "short", "sbyte", "byte", "ushort", "int"));
        Console.WriteLine(String.Format("|{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|", a, b, c, d, e));

    }
}

