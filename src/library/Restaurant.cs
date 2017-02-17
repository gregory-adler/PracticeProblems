namespace Library{
    using System;
    using System.Collections.Generic;

    public class Restaurant{
        public Host Host{get; set;}
        public List<Server> Servers {get; set;}
        public List<Party> Parties{get;set;}
        public List<Table> Tables{get;set;}


    }
    public class Party: Restaurant{
        public List<Guest> Guests {get; set;}

    }
    public class Guest: Restaurant{
        public string Name {get; set;}

    }

    public class Table : Restaurant{
        public Party Party {get; set;}
    }

    public class Employee : Restaurant{
        public string Name {get; set;}
        public int Salary{get; set;}
        public string Type {get; set;}

        public void EmployeeProperties(){
            Console.WriteLine("EmployeeProperties");
            Console.WriteLine($"    Type = {Type}");
            Console.WriteLine($"    Name = {Name}");
            Console.WriteLine($"    Salary = {Salary}$");
        }
    }
    public class Host: Employee{
        public Host(string name, int salary, string type){
            this.Name = name;
            this.Salary = salary;
            this.Type = "Host";
        }

    }
    public class Server : Employee{
        public Server(string name, int salary){
            this.Name = name;
            this.Salary = salary;
            this.Type = "Server";
        }
        
    }
}