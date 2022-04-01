using System;
using System.Collections.Generic;
using System.Text;

namespace classwork
{
    class product
    {
        public int No;
        public string Name;
        public double Price;
        public int Count; 
        public product(int no,string name,double price,int count)
        {
           

            if (no!=0 || name!="" || name!=" " || price!=0 || count!=0)
            {
                Name = name;
                No = no;
                Price = price;
                Count = count;
            }
            else
            {
                Console.WriteLine("Parametrleri daxil edin");
            }
        }
    }
}
