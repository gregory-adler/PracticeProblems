namespace Library{
    using System;
    using System.Collections.Generic;

    public class Restaurant{
        public Host Host{get; set;}
        private List<Server> Servers {get; set;}
        private List<Party> Parties{get;set;}
        private List<Table> Tables{get;set;}


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
    }
    public class Host: Employee{
        public Host(string name, int salary){
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