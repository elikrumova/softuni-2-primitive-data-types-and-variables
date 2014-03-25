using System;

class StringsObjects
{
    static void Main()
    {
        string string_f = "Hello";
        string strong_s = "World";
        object concatenation = string_f + " " + strong_s;
        string newString = (string)concatenation;
        Console.WriteLine(newString);
    }
}

