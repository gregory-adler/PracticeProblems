namespace Library{

    using System;
    using System.Collections.Generic;
    public class dictionaryPractice{

        public void setup(){
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Test",1);
            if (dictionary.ContainsKey("Test")){
                Console.WriteLine(dictionary["Test"]);
            }
        }
    }
}