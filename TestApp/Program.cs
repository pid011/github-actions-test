using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(args[0]);
        Console.WriteLine($"arg length is {args[0].Length}");
    }
}