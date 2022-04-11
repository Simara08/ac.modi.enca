using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment {
    class NewGrup
    {
        private string _no;
        public string No { get; set; }
        
        private bool _isonline;
        public bool IsOnline { get; set; }
        private int _limit;
        public int Limit
        {
            get
            {
                if (_isonline == true)
                {
                    return 15;
                }
                else
                {
                    return 10;
                }
            }
            set
            {
                value = _limit;
            }
        }

        public List<Student> students;
        public Category categories;
        public static int Bp = 100;
        public static int Dp = 100;
        public static int Ad = 100;
        public NewGrup(Category category,bool isonline)
        {
            IsOnline = isonline;
            switch (category)
            {
                case Category.Programing:
                    No = $"Bp:{Bp}";
                    Bp++;
                    break;
                case Category.Design:
                    No = $"Dp:{Bp}";
                    Dp++;
                    break;
                case Category.SystemAdminstrator:
                    No = $"Ad:{Ad}";
                    Ad++;
                    break;
                default:
                    Console.WriteLine("bele bir qrup yoxdur duzgun kteqoriya sechin");
                    break;
            }

        }

    }
}

//      private bool _isonline;
//public bool IsOnline

    //get
    //{
    //    if (_limit == 15 || _limit == 10)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
    //set
    //{
    //    value = _isonline;
    //}


    

