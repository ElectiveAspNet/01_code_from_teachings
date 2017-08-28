using System;

namespace MyFirstDotNetApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Person p = new Person("Claus");
            Console.WriteLine(p.getName());
            p.Name = "Hening";
            Console.WriteLine(p.Name);

            // System.out.println("Hello World");
        }
    }
}
