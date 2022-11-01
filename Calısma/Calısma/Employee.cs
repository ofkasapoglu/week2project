using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma
{
    public class Employee
    {
        public int Age { get; set; }
        public string Employees { get; set; }
        public string FirstName { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }

        public Employee()
        {
            Console.WriteLine("Employee class initilize..");
        }


        public Employee(int age, string firstname, string lastname, int id, string employees)
        {
            Age = age;
            FirstName = firstname;
            LastName = lastname;
            Employees = employees;
            Id = id;
        }


        public override string? ToString()
        {
            return $"{Age} {Employees} {FirstName} {Id} {LastName}";
        }
    }
}
