using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace BasicWebII
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = WebHost.CreateDefaultBuilder().UseStartup<Startup>().Build();
            host.Run();


            //Console.WriteLine("Hello World!");
        }
    }
}
