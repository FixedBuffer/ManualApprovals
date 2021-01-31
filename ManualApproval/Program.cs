using System;

namespace ManualApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            var env = Environment.GetEnvironmentVariable("MYVAL");
            int.TryParse(env, out var id);
            var message = id switch
            {
                1 => "Development",
                2 => "Production",
                _ => "MYVAL is not defined"
            };
            Console.WriteLine(message);
        }
    }
}
