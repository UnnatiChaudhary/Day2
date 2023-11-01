using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Test : Sports
    {
        int[] marks = new int[5] {1,2,3,4,5};
        public int totalMarks;
        public Test()
        {
            
        }
        public void Display()
        {
            base.Display();
            int sum = 0;
            for(int i = 0;i < 5;i++)
            {
                sum+= marks[i];
            }
            totalMarks = sum;
            Console.WriteLine("Total Marks are: "+totalMarks);
            int result = totalMarks + score;
            Console.WriteLine("resut is: " + result);
        }
    }
}
