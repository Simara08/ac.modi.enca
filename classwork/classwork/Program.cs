using System;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Array-in olchusunu daxil edin");
            int size = Convert.ToInt32(Console.ReadLine());
            book[] books = new book[size];
            int i = 0;

            for (i = 0; i < size; i++)
            {
                Console.WriteLine("kitabin nomresini daxil edin");
                books[i].No = int.Parse(Console.ReadLine());
                Console.WriteLine("kitabin adini daxil edin");
                books[i].Name = Console.ReadLine();
                Console.WriteLine("kitabin qiymetini daxil edin");
                books[i].Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("kitabin janrini daxil edin");
                books[i].Genre = Console.ReadLine();
            }

        }
    }
}
