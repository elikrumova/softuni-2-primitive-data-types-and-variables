using System;
class NullValuesArithmetic
{
    static void Main()
    {
        int? nullInt = null;
        Console.WriteLine(nullInt);
        double? nullDouble = null;
        Console.WriteLine(nullDouble);
        nullInt = 5;
        Console.WriteLine(nullInt.GetValueOrDefault());
        nullDouble = 10;
        Console.WriteLine(nullDouble.GetValueOrDefault());
    }
}

