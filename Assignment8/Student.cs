using System.Reflection.Metadata;

namespace Assignment8
{
    internal class Student
    {
        int rn;
        public string name;
        public Student()
        {
                
        }
        public Student(int rn,string name)
        {
            this.rn = rn;
            this.name = name; 
        }
        public  void Display()
        {
            Console.Write("Enter roll number:");
            rn=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name:");
            name=Console.ReadLine();
            Console.WriteLine("Student name is: "+name +" And Roll Number is: "+rn);
        }
    }
}