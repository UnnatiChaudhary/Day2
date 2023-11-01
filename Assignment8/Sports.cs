using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Sports:Student
    {
        string sportsName;
        public int score;
        public Sports()
        {
            
        }
        public Sports(string sportsName,int score)
        {
            this.sportsName = sportsName;
            this.score = score;
        }
        public void Display()
        {
            base.Display();
            Console.Write("Enter Sports name: ");
            sportsName = Console.ReadLine();
           
            Console.Write("Enter score: ");
            score=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sports Name is: " + sportsName+ "score is: " + score);
         
        }
    }
}
