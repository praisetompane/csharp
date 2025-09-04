using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Student
    {
        public int mIdNumber { get; set; }
        public string mName { get; set; }
        public double GradePointAverage { get; set; }

        public Student(int Num,string Name,double GPA)
        {
            mIdNumber = Num;
            mName = Name;
            GradePointAverage = GPA;
        }

    }
}
