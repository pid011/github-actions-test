using System;

string value = Environment.GetEnvironmentVariable("TestKey");
Console.WriteLine(value ?? "Cannot found enviroment varivable.");