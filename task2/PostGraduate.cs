using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class PostGraduate:Student
    {
        public string ThesisTopics {  get; set; }

        public new  void PrintDetails()
        {

            Console.WriteLine("Graduated students:");
            Console.WriteLine($"Name: {this.Name}\nAge:{this.Age}\nGrade: {this.Grade}\nThesis Topic: {this.ThesisTopics}");
           

        }
    }
}
