using System;
using System.Collections.Generic;

namespace Library
{
    public class Restaurant
    {
        private string name{get; set;}
        private List<Employee> Employees {get;set;}
        private List<Party> Parties {get;set;}
        private List<Table> Tables {get; set;}
        public void Restauarant(string _name, List<Employee> _Employees, List<Party> _Parties, List<Table> _Tables)
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
        private string name {get;set;}
        private int age {get;set;}
        private string type {get;set;}
        
        public void setName(string _name)
        {
            this.name = _name;
        }
        
        public void setAge(int _age)
        {
            this.age = _age;
        }
        
        public void setType(string _type){
            this.type = _type;
        }
        public string getName()
        {
            return this.name;
        }
        public int getAge()
        {
            return this.age;
        }

        public string getType(){
            return this.type;
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Employee");
            Console.WriteLine("Type: " + this.type);
            Console.WriteLine("Age: " + this.age);
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine();
        }
    }
    public class Server :Employee
    {
        public Server(string _name, int _age)
        {
            setName(_name);
            setAge(_age);
            setType("Server");

        }
    }

    public class Party{
        
    }

    public class Table{

    }
}
