using System;

namespace ManualApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            var env = Environment.GetEnvironmentVariable("MyVal");
            if(!string.IsNullOrWhiteSpace(env))
                Console.WriteLine($"The value of MyVal is:{env}");
            Console.WriteLine("MyVal is not defined");
        }
    }
}
