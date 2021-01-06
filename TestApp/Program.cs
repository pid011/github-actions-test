using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(args[0]);
        Console.WriteLine($"arg length is {args[0].Length}");

        Console.WriteLine();

        string secrets = Environment.GetEnvironmentVariable("TEST_KEY", EnvironmentVariableTarget.Process);
        if (secrets is not null)
        {
            Console.WriteLine($"env length is {secrets.Length}");
        }
        else
        {
            Console.WriteLine("Cannot found env...");
        }
    }
}