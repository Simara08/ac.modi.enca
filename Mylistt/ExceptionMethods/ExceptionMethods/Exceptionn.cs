using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionMethods
{
     public static  class Exceptionn
    {

        public static bool CustomContains(this string str,string word)
        {
            if (str.Contains(word))
            {
                return true;
            }
            return false;
        }
        public static bool CustomContains(this string str, char w)
        {
            if (str.Contains(w))
            {
                return true;
            }
            return false;
        }
        public static  bool IsPrime(this int num)
        {
            int i;
            for ( i = 2; i < num; i++)
            {
                if (num%i==0)
                {
                    return false;
                }
            }
            if (i==num)
            {
                return true;

            }
            return false;
        }
    }
}
