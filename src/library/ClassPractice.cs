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

        public Restaurant(string _name, List<Employee> _Employees, List<Party> _Parties, List<Table> _Tables)
        {
            this.name = _name;
            this.Employees = _Employees;
            this.Parties = _Parties;
            this.Tables = _Tables;
        }
        public void Print()
        {
            Console.WriteLine("Employees");
            foreach (Employee employee in Employees){
                employee.Print();
            }
            Console.WriteLine("Parties");
            foreach (Party party in Parties)
            {
                party.Print();
            }
            Console.WriteLine("Tables");
            foreach (Table table in Tables)
            {
                table.Print();
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
    public class Server:Employee
    {
        private Table table {get;set;}
        public Server(string _name, int _age)
        {
            setName(_name);
            setAge(_age);
            setType("Server");

        }

        public void assignTable(Table _table){
            this.table = _table;
        }
        public Table getTable(){
            return this.table;
        }
    }

    public class Host : Employee
    {
        public Host(string _name, int _age)
        {
            setName(_name);
            setAge(_age);
            setType("Host");
        }
    }

    public class Party{
       private List <Customer> Customers {get;set;}
       private Table table {get; set;}

       private Boolean waiting {get; set;}

       public Party(int _count, Boolean _waiting){
           setParty(_count);
           setWaiting(_waiting);
       }
       public Party(int _count, Table _table){
           setParty(_count);
           setTable(_table);
       }
       public void setParty(int _count){
            List<Customer> _Customers = new List<Customer>();
            for (int i = 1; i<= _count; i++){
                _Customers.Add(new Customer(i));
            }
           this.Customers = _Customers;
       }
       
       public void setWaiting(Boolean _waiting){
           this.waiting = _waiting;
       }
       public void setTable(Table _table){
           this.table = _table;
       }

       public List<Customer> getCustomers(){
           return this.Customers;
       }
        public Table getTable(){
            return this.table;
        }

       public void Print(){
           Console.WriteLine ("\n" + "Party");
           Console.WriteLine("Party size: " + this.Customers.Count);
           if (this.waiting)
            {
                Console.WriteLine("Waiting");
            }
           else {
                Console.WriteLine("Table: " + this.table.getNumber());
            }
            Console.WriteLine();
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
        private int size {get;set;}
        private Boolean available {get;set;}
        private Party party { get; set; }

        public Table(int _number, int _size){
            setNumber(_number);
            setSize(_size);
            setAvailable(true);
        }

        public void Print (){
            Console.WriteLine ("\n" + "Table: ");
            Console.WriteLine("Table Number: " + this.getNumber());
            Console.WriteLine("Table Size: " + this.getSize());
        }
        public void setNumber(int _number){
            this.number = _number;
        }
        public void setSize(int _size){
            this.size = _size;
        }

        public void setAvailable(Boolean _available){
            this.available = _available;
        }

        public void setParty(Party _party)
        {
            this.party = _party;
        }
        public int getNumber(){
            return this.number;
        }

        public int getSize(){
            return this.size;
        }

    }
}
