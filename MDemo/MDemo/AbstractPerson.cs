using System;
namespace MDemo
{
    public class AbstractPerson
    {
        public AbstractPerson()
        {
        }
    }

    public class Person : AbstractPerson {
    }

    public class Employee : Person, IComparable<Employee> {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int Age { set; get; }
        public double Salary { set; get; }


        public Employee() { }

        public Employee(int Id, int Age, string LastName, string FirstName, double Salary) {
            this.Id = Id;
            this.Age = Age;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Salary = Salary;
        }

        public int CompareTo(Employee other)
        {
            return this.LastName[0] - other.LastName[0];
        }
    }
}
