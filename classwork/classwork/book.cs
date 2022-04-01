using System;
using System.Collections.Generic;
using System.Text;

namespace classwork
{
    class book:product
    {
        public string Genre;
        public book(string genre ,int no, string name, double price, int count):base(no,name,price,count)
        {
            
            if (genre!="" || genre!=" ")
            {
                Genre = genre;
            }
            Console.WriteLine("Janri daxil edin");
          
    }
        
    }
}
