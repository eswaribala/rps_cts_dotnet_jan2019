using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class Student
    {
        public int RollNo{get;set;}
        public string Name { get; set; }
        public int[] Marks { get; set; }
       public Student(int size)
        {
            this.Marks = new int[size];
        }

    }
}
