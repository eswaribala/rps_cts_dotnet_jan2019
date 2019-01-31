using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class StudentApp
    {
        static void studentscoredemo()
        {
            //two dimensional array
            Console.WriteLine("Enter No of Students");
            int row = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter No of Subjects");
            int col = Convert.ToInt16(Console.ReadLine());

            int[,] StudentArray = new int[row, col];

            //read the marks

            for (int i = 0; i < row; i++)
            {
                Console.WriteLine("Enter Marks for the Student{0}", i + 1);
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("Enter Mark for the Subject{0}", j + 1);
                    StudentArray[i, j] = Convert.ToInt16(Console.ReadLine());

                }
            }

            //compute the total
            int total;
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine("Student{0}", i + 1);
                total = 0;
                for (int j = 0; j < col; j++)
                {
                    total += StudentArray[i, j];

                }
                Console.WriteLine("Total={0}", total);
            }
        }


        static void Main(string[] args)
        {
            //two dimensional array
            Console.WriteLine("Enter No of Sections");
            int row = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter No of Students");
            int col = Convert.ToInt16(Console.ReadLine());
            Student[,] StudentArray = new Student[row, col];

            //read the marks
            Student student;
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine("Enter details of the Section{0}", i + 1);
                student = null;
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("Enter the details of the Student{0}", j + 1);
                    student = new Student(5);
                    student.RollNo = new Random().Next(10000);
                    Console.WriteLine("Enter Name");
                    student.Name = Console.ReadLine();
                    for(int k=0;k<student.Marks.Length;k++)
                    {
                        Console.WriteLine("Enter Marks{0}", k + 1);
                        student.Marks[k] = Convert.ToInt16(Console.ReadLine());
                    }
                    StudentArray[i, j] = student;

                }
            }

            //let us compute the average

            int indTotal;
            int indAverage;
            int secSum;
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine("Average for Section{0}", i + 1);
                secSum = 0;
                for (int j = 0; j < col; j++)
                {
                    indTotal = 0;
                    indAverage = 0;
                    for (int k=0;k<StudentArray[i,j].Marks.Length;k++)
                    {
                        indTotal += StudentArray[i, j].Marks[k];
                    }
                    indAverage = indTotal / StudentArray[i, j].Marks.Length;
                    secSum +=  indAverage;


                }
                Console.WriteLine("Section Average={0}", secSum / col);

            }


                Console.Read();





        }
    }
}
