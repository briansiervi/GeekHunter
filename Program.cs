using System;
using System.IO;
public class Test
{
    public static string processInput(string input)
    {
        return input;
    }

    public static void Main()
    {
        foreach (string line in File.ReadLines(@"input.txt"))
        {
            Console.WriteLine(line);
        }
    }
}