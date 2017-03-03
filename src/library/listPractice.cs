namespace Library {
    
    using System.Collections.Generic;
    using System;
    public class listPractice{
        public static void setup(){
        List<string> dinosaurs = new List<string>();
        dinosaurs.Add("The");
        dinosaurs.Add("Another");
        foreach (var test in dinosaurs){
            Console.WriteLine(test);
        }

        List<int> numbers = new List<int>{1,2,3,4};
        
        foreach (var number in numbers){
            Console.WriteLine(numbers.Contains(4));
        }
        Console.WriteLine(numbers.Count);
        }
    }

}