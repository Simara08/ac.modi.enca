using System;
using System.Collections.Generic;

namespace Printable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Language> languages = new List<Language>();
            languages.Add(new Language("C#", 1999));
            languages.Add(new Language("C++", 1983));
            languages.Add(new Language("Java", 1995));
            Console.WriteLine("Language sorted by Name");
            languages.Sort(new LanguagetNameComparer());
            foreach (Language item in languages)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Language sorted by CreationDate");
            languages.Sort(new LanguageDateComparer());
            foreach (Language item in languages)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
