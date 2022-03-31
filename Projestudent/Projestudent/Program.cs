using System;

namespace Projestudent
{
    class Program
    {
        static void Main(string[] args)
        {
           Student student1 = new Student(77, "Simara", "Maharramli", "CS");

            Group gr1 = new Group();
            gr1.AddStudent(student1);
        }
    }
}
