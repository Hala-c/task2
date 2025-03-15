using task2;


Console.WriteLine("Enter number of students");
int num = int.Parse(Console.ReadLine());

Student[] g2 = new Student[num];

Student.Promptdetails_students(num, g2);  
Student.Display_studentdetails(num, g2);

Console.WriteLine("--------------------------------------------------");

PostGraduate postGraduate = new PostGraduate();      // one only for exmaple 
postGraduate.Name = "amira";
postGraduate.Age = 22;
postGraduate.Grade = 95;
postGraduate.ThesisTopics = "machine learning";

postGraduate.PrintDetails();









