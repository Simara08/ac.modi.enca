using System;

namespace ExceptionMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 7;
            string Wordd = "how are you baby";
            
            Console.WriteLine(a.IsPrime());
            Console.WriteLine(Wordd.CustomContains("are"));
        }
    }
}
