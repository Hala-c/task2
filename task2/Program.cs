using task2;


#region student

Console.WriteLine("Enter number of students");
int num = int.Parse(Console.ReadLine());
Student[] g2 = new Student[num];

Student.Promptdetails_students(num, g2);
Student.Display_studentdetails(num, g2);

#endregion
Console.WriteLine("--------------------------------------------------");

#region post graduates
PostGraduate postGraduate = new PostGraduate();      // one only for exmaple 
postGraduate.Name = "amira";
postGraduate.Age = 22;
postGraduate.Grade = 95;
postGraduate.ThesisTopics = "machine learning";

postGraduate.PrintDetails();

#endregion


#region employee
Console.WriteLine("----------------------------------");
Console.WriteLine("Employee part");
Employee e = new Employee("ahmed", 3, 56789, 'M', new DateTime(2025,5,15),Securityprevilige.Developer);
Console.WriteLine(e);

#endregion






