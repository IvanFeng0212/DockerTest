//// See https://aka.ms/new-console-template for more information
//var counter = 0;
//var max = args.Length != 0 ? Convert.ToInt32(args[0]) : -1;
//while (max == -1 || counter < max)
//{
//    Console.WriteLine($"Counter: {++counter}");
//    await Task.Delay(TimeSpan.FromMilliseconds(1_000));
//}

using System;

namespace DotNet.Docker.First // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}