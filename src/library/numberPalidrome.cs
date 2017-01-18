namespace Library {
    using System;
    public class NumberPalidrome{
        public bool isPalidrome(int x){
            string original = x.ToString();
            string reverse = "";
            int number;
            for (int i = (original.Length-1); i>=0; i--){
                if (original[i].Equals('-')){
                    reverse = original[i] + reverse;
                    return false;
                    continue;
                }
                reverse = reverse + original[i];
            }
            Console.WriteLine(reverse);
            bool newNumber = Int32.TryParse(reverse, out number);
            if (newNumber){
                if (number == x){
                    return true;
                }
            }
            return false;
        }
        public bool isPalidrome2(int x){
        return false;
    }
    }
}