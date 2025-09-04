using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {

            //Employee
            Employee _emp = new Employee();
            Console.WriteLine("Enter ID :");
            int.TryParse(Console.ReadLine(), out _emp.mID);
            Console.WriteLine("Enter name :");
            _emp.mName = Console.ReadLine();
            Console.WriteLine("Enter Salary :");
            double.TryParse(Console .ReadLine (),out _emp .mSalary );

            //WRITING FROM FILE
            FileStream ofstream = new FileStream("EmployeeData.txt",FileMode.Create,FileAccess .Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(ofstream ,_emp );

            ofstream.Close();
            //READING FROM FILE
            FileStream ifstream = new FileStream("EmployeeData.txt",FileMode.Open , FileAccess.Read);
            //Read object sored into variable object created
            Employee _emp2 = new Employee ();
            //First parenthesis take the object type.Second parenthesis take stream to read it from
            _emp2 = (Employee)bFormatter.Deserialize(ifstream);

            while (_emp2 != null)
            {
                //Console.WriteLine("{0,1}{3,1}{6,1}","ID","Name","Salary");
                Console.WriteLine("{0,-5}{1,-12}{2,8}", "ID", "Name", "Salary");
                Console.WriteLine("{0,-5}{1,-12}{2,8}", _emp2.mID, _emp2.mName, _emp2.mSalary);
                _emp2 = (Employee)bFormatter.Deserialize(ifstream);
                
            }
            Console.ReadLine();
        }
    }
}
