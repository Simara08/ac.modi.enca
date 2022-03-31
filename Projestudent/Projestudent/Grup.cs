using System;
using System.Collections.Generic;
using System.Text;

namespace Projestudent
{
    class Grup
    {
        public string GroupName
        {
            get
            {
                return GroupName;
            }
            set
            {
                GroupName = value;
            }
        }

        public int MaxStuCount
        {
            get
            {
                return MaxStuCount;
            }
            set
            {
                MaxStuCount = value;
            }
        }
        public Student[] Students = new Student[] { };
        public void AddStudent(Student stu1)
        {
            if (Students.Length + 1 > MaxStuCount)
            {
                Student[] newStudents = new Student[Students.Length + 1];
                for (int i = 0; i < Students.Length; i++)
                {
                    newStudents[i] = Students[i];
                }
                newStudents[newStudents.Length - 1] = stu1;
                Students = newStudents;
                Console.WriteLine(Students[0].Name);

            }
            else
            {
                Console.WriteLine("Bu qrup doludur. Bu qrupa yeni tələbə əlavə etmək mümkün deyil!!!");
            }

        }
        public void RemoveStudent(int id)
        {
            Student[] newStudents = new Student[Students.Length - 1];
            int targetIndex = 0;
            for (int i = 0; i < Students.Length; i++)
            {
                if (id != Students[i].Id)
                {
                    newStudents[i] = Students[i];
                    targetIndex++;
                }
                else
                {
                    return;
                }
            }
            for (int j = targetIndex; j < Students.Length; j++)
            {
                newStudents[j] = Students[j + 1];

            }
            Students = newStudents;

        }

    }
}
