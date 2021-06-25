using System;

namespace HelloWorldRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HelloWorld hello = new HelloWorld();
            hello.SayHello();
        }
    }
}
