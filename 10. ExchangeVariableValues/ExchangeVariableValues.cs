using System;
class ExchangeVariableValues
{
    static void Main()
    {
        int variableA = 5;
        int variableB = 10;
        Console.WriteLine("Before\n" + variableA);
        Console.WriteLine(variableB);

        int variableC = variableA;
        variableA = variableB;
        variableB = variableC;

        Console.WriteLine("After\n" + variableA);
        Console.WriteLine(variableB);
    }
}

