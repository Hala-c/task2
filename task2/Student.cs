using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
   internal class Student
    {
        public static int c = 0;

        public Student() { c++; }
        public string Name {  get; set; }
        public int Age{ get; set; }
        public double Grade {  get; set; }

        public void PrintDetails()
        {
           
            Console.Write($"\t{this.Name}\t{this.Age}\t{this.Grade}");
        }


        public static void Promptdetails_students(int num, Student[] g2)
        {

            for (int i = 0; i < num; i++)
            {
                g2[i] = new Student();

                Console.Write("student name: ");
                g2[i].Name = Console.ReadLine();

                Console.Write("student age: ");
                g2[i].Age = int.Parse(Console.ReadLine());

                Console.Write("student grade: ");
                g2[i].Grade = double.Parse(Console.ReadLine());

                Console.WriteLine();

            }
        }

        public  static void Display_studentdetails(int num, Student[] g2)
        {

            char flag;
            Console.WriteLine("Do you want to show all details for students?y/n");
            flag = char.Parse(Console.ReadLine().ToLower().ToLower());

            if (flag == 'y')
            {


                Console.WriteLine("Student Table:\n\tName\tAge\tGrade\n");

                for (int i = 0; i < num; i++)
                {

                    g2[i].PrintDetails();
                    Console.WriteLine();


                }
            }
            else
            {
                Console.WriteLine("okey...");
            }
        }
    }
}
