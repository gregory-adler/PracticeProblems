namespace Library{
    using System;

    public class RomanNumerals{
        public string IntToRoman(int num){
            
            int count = 1;
            int remainder;
            char[] roman = new char[5];
            roman[0] = 'I';
            roman[1] = 'V';
            roman[2] = 'X';
            roman[3] = 'C';
            roman[4] = 'M';
            string answer = "";

            while (true){
                if (num % (Math.Pow(10,count)) == num){
                    break;
                }
                else {
                    count = count +1;
                }
            }
            count = count -1;
            
            //Console.WriteLine(count);
           while (count >= 1){
              // Console.WriteLine(count);
              // Console.WriteLine(answer);
              remainder = Convert.ToInt32(Math.Floor(num / (Math.Pow(10,count))));
              Console.WriteLine((Math.Pow(10,count)*remainder));
              num = Convert.ToInt32(num - (Math.Pow(10,count)*remainder));
              Console.WriteLine("num");
              Console.WriteLine(num);
               for (int i = 0; i < remainder; i++){
                   answer = answer + roman[count+1];
               }
               count = count -1;
           }
          // Console.WriteLine(num);
           if (num >= 5){
               answer = answer + roman[1];
               num = num-5;
           }
           for (int i = 1; i<= num; i++){
               answer = answer + roman[0];
           }
           Console.WriteLine(answer);
           if (answer.Contains("CCCCCCCCC")){
               Console.WriteLine("4");
               answer = answer.Replace("CCCCCCCCC", "CM");
           }
            if (answer.Contains("CCCCC")){
               Console.WriteLine("4");
               answer = answer.Replace("CCCCC", "D");
           }
            if (answer.Contains("CCCC")){
               Console.WriteLine("4");
               answer = answer.Replace("CCCC", "CD");
           }
           if (answer.Contains("XXXXXXXXX")){
               Console.WriteLine("5");
               answer = answer.Replace("XXXXXXXXX", "XC");
           }
           if (answer.Contains("XXXXX")){
               Console.WriteLine("4");
               answer = answer.Replace("XXXXX", "L");
           }
           if (answer.Contains("XXXX")){
               Console.WriteLine("4");
               answer = answer.Replace("XXXX", "XL");
           }
            if (answer.Contains("VIIII")){
               Console.WriteLine("2");
               answer = answer.Replace("VIIII", "IX");
           }
           if (answer.Contains("IIII")){
               Console.WriteLine("1");
               answer = answer.Replace("IIII", "IV");  
           }
           if (answer.Contains("XXXXX")){
               Console.WriteLine("3");
               answer = answer.Replace("XXXXX", "L");
           }
           return answer;
        }
    }
}