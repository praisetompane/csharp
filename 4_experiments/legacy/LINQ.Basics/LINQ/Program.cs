using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

///2011/11/28 10:00
///LINQ basics
///
namespace LINQ
{  
    class Program
    {
        static void Main(string[] args)
        {
            //EXAMPLE 1
            /*int[] Numbers = { 6, 4, 2, 1, 3, 8, 7, 5, 2, 0,4,9,9,4 };
            const int CUTOFF = 3;
            var highNumbers =
                           from x in Numbers//Indicates collection
                           where x > 3//where is the restriction operator
                           select 4;//Indicates what to selects
            Console.Write("Numbers greater than {0} ",CUTOFF + "\n");
            foreach (var a in highNumbers)
            {
                Console.Write(a + " ");
                
            }
            Console.ReadLine();*/
            //END OF EXAMPLE 1

            //EXAMPLE 2
            Student[] _Students = {
                                       new Student (1, "Jones",    3.1),
                                       new Student (2, "Kimball",  2.9),
                                       new Student (3, "Oliver",   2.6),
                                       new Student (4, "Mitchell", 3.0),
                                       new Student (5, "Lee",      4.0),
                                       new Student (6,  "Cooper",  3.5),
                                   };
            const double CUTOFF = 3.0;
            Console.WriteLine("Students with GPA > {0}",CUTOFF);

            var goodStudents =
                             from s in _Students//s represtns the instance of Student class
                             where s.GradePointAverage > CUTOFF
                             select s;

            Console.WriteLine("{0,3} {1,-8} {2,5}", "ID", "Name", "GPA");
            foreach (Student a in goodStudents)
            {
              
                Console.WriteLine("{0,3} {1,-8} {2,5}",a.mIdNumber,a.mName,a.GradePointAverage);
            }
            Console.ReadLine();
        }
    }
}
