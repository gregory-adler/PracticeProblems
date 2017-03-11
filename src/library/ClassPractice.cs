using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Restaurant
    {
        private List<Employee> Employees = new List<Employee>();
        public void Restauarant(List<Employee> _Empoloyees, string name)
        {

        }
        public void Print()
        {
           foreach (Employee employee in Employees){
                employee.Print();
            }

        }
    }
    public abstract class Employee
    {
        private string name;
        private int age;
        
        public void setName(string _name)
        {
            this.name = _name;
        }
        
        public void setAge(int _age)
        {
            this.age = _age;
        }

        public string getName()
        {
            return this.name;
        }
        public int getAge()
        {
            return this.age;
        }

        public void Print()
        {
            Console.WriteLine("Employee");
            Console.WriteLine("age: " + this.age);
            Console.WriteLine("name: " + this.name);
        }
    }
    public class Server :Employee
    {
        public Server(string _name, int _age)
        {
            setName(_name);
            setAge(_age);

        }
    }
}
