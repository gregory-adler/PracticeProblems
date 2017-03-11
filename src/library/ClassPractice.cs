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
       private List <Customer> Customers {get;set;}

       public Party(int _count){
           setParty(_count);
       }
       public void setParty(int _count){
            List<Customer> _Customers = new List<Customer>();
            for (int i = 1; i<= _count; i++){
                _Customers.Add(new Customer(i));
            }
           this.Customers = _Customers;
       }

       public List<Customer> getParty(){
           return this.Customers;
       }

       public void Print(){
           Console.WriteLine ("\n" + "Party");
           Console.WriteLine("Party size: " + this.Customers.Count);
       }
        
    }
    public class Customer {
        private int number;

        public Customer(int _number){
            setNumber(_number);
        }
        public void setNumber(int _number){
            this.number = _number;
        }
        public int getNumber(){
            return this.number;
        }

        }

    public class Table{
        private int number {get; set;}

        public Table(int _number){
            setNumber(_number);
        }

        public int getNumber(){
            return this.number;
        }
        public void setNumber(int _number){
            this.number = _number;
        }

    }
}
