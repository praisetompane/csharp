using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Searching.Sequntial.File
{
    class Program
    {
        static void Main(string[] args)
        {
            //This separates the data items in the file.To make it easier to ealier read from
            const char DELIM = ',';
            //Termination ID
            const double END = 999;
            double dblsalary = 0;
            // out a(variable name) is the variable to store the conversion result
            double a;
            //SEARCHING A SEQUENTIAL FILE

           
           

            //Employee instance
            Employee _emp = new Employee();

            //READING
            //Variables to read data into
            string ReadData;
            //Stores only three items.the employee data at once
            string[] FileContents = new string[3];
            //Input stream for the program

            FileStream inputStream = new FileStream("Employee.txt", FileMode.Open, FileAccess.Read);
            //Linking to stream
            StreamReader reader = new StreamReader(inputStream);

            //Reading data
            ReadData = reader.ReadLine();

            inputStream.Seek(0, SeekOrigin.Begin);
            do
            {
                Console.WriteLine("Enter a salary.I will get salaries of employees in close proximity to yours or {0} to terminate", END);
                //Another conversion method.First argument is the input to be converted

                double.TryParse(Console.ReadLine(), out a);

                
                FileContents = ReadData.Split(',');
                if (dblsalary >= Convert.ToDouble(FileContents[2]))
                {
                    Console.WriteLine("{0,-5}{1,-12}{2,8}", "ID", "Name", "Salary");
                    //Read data is split and used to populate the array

                    _emp.mID = FileContents[0];
                    _emp.mName = FileContents[1];
                    _emp.mSalary = Convert.ToDouble(FileContents[2]);
                    Console.WriteLine("{0,-5}{1,-12}{2,8}", _emp.mID, _emp.mName, _emp.mSalary);
                }
                
                ReadData = reader.ReadLine();
            }
            while (dblsalary  != END);
            
            /*while (ReadData != END)
            {
                
                //Sets the file position pointer to zero
                //The file position pointer holds the byte number of the next byte to be read.It holds a specific position in a file
                //Resets file position pointer
                inputStream.Seek(0,SeekOrigin.Begin);
                FileContents = ReadData.Split(',');
                if(dblsalary >= Convert .ToDouble (FileContents [2]))
                {
                //Read data is split and used to populate the array
                
                _emp.mID = FileContents[0];
                _emp.mName = FileContents[1];
                _emp.mSalary = Convert.ToDouble(FileContents[2]);
                Console.WriteLine("{0,-5}{1,-12}{2,8}", _emp.mID, _emp.mName, _emp.mSalary);
                }
                Console.WriteLine("Enter a salary.I will get salaries of employees in close proximity to yours or {0} to terminate", END);
                ReadData = reader.ReadLine();
            }*/


            /*while (ReadData != null)
            {
                
                //Specifies how to separate the data into elements
                
                
                //When a ',' is found that latter content is stored into the array,and so forth.
                if (dblsalary > Convert.ToDouble(FileContents[2]))
                {
                     //Assigning read values to _emp
                    _emp.mID = FileContents[0];
                    _emp.mName = FileContents[1];
                    _emp.mSalary = Convert.ToDouble(FileContents[2]);
                }
                Console.WriteLine("{0,-5}{1,-12}{2,8}", _emp.mID, _emp.mName, _emp.mSalary);
                //Reading data
                ReadData = reader.ReadLine();
            }*/

            
            Console.ReadLine();
            reader.Close();
            inputStream.Close();
        }
    }
}
