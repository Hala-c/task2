using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{

    public enum Securityprevilige
    {
        guest,
        Developer,
        secretary,
        DBA

    }

    internal class Employee
    {
        private char gender;
        public string Name {  get; set; }
        public int Id {  get; set; }
        public double Salary {  get; set; }
        public DateTime HireDate {  get; set; }
        public Securityprevilige SecurityLevel {  get; set; }
        public char Gender
        {
            get 
            {
               return gender;
                }
            set
            {
           
                
                if (value == 'F' || value == 'M')
                    gender = value;
                else
                    Console.WriteLine("This is Not valid ,it must be F/M");
            }

            
        }

        //CONSTRCUTOR
        public Employee(string name,int id,double salary,char gender,DateTime hiredate,
            Securityprevilige securitylevel)
        {
            Name = name;
            Id = id;
            Salary = salary;
            Gender = gender;
            HireDate = hiredate;
            SecurityLevel = securitylevel;
             
        }
        public override string ToString()
        {

            return $"ID: {this.Id}\nName: {this.Name}\nSalary: {string.Format("{0:C}", this.Salary)}\nGender: {this.Gender}\n" +
                $"Hire Date: {this.HireDate}\nSecurity Level: {this.SecurityLevel}";


        

        }

    }

     
    
}


