namespace Library
{
    using System.Collections.Generic;
    using System;

    public class IPAddress
    {
        public String ValidIPAddress(string IP)
        {
            Console.WriteLine("IPAddress: " + IP + "\n");

            Boolean result;

            int periodCount = 0;
            int colonCount = 0;
            for (int i = 0; i < IP.Length; i++) {
                if (IP[i].Equals('.'))
                {
                    if (i == 0 || i == IP.Length - 1)
                        return "Neither";
                    periodCount++;
                }


                if (IP[i].Equals(':'))
                {
                    if (i == 0 || i == IP.Length - 1)
                        return "Neither";
                    colonCount++;
                }
                   
            }

            if (!(colonCount == 7 ^ periodCount == 3) || !(colonCount > 0 ^ periodCount > 0))
                return "Neither";

            foreach (char letter in IP){
                if (letter == '.')
                {
                    result = IPV4(IP);
                    if (result)
                    {
                        return "IPv4";
                    }
                    else
                    {
                        return "Neither";
                    }
                }
                if (letter == ':')
                {
                    result = IPV6(IP);
                    return "IPv6";
                }
            }
            return "Neither";
        }
        public Boolean IPV4(string address)
        {
            Console.WriteLine("IPV4" + "\n");
            if (address.Length == 0)
            {
                return true;
            }

            string remainderString ="";
            string testString = null;
        
            for (int i = 0; i< address.Length; i++)
            {
                if (address[i] == '.')
                {
                    remainderString = address.Substring(i + 1);
                    testString = address.Substring(0, i);
                    break;
                }
            }
            Console.WriteLine("remainder: " + remainderString);
            Console.WriteLine("test: " + testString + "\n");

              if (testString.Length > 1 && testString[0] == '0'){
                Console.WriteLine("returns false here");
                return false;
            }

            if (testString == null)
            {
                testString = address;
            }

            if (testString[0] == '0' && testString.Length > 1)
            {
                return false;
            }

            for (int i = 0; i < testString.Length; i++)
            {

                //Number check
                if (!(Char.IsDigit(testString[i])))
                {
                    return false;
                }
            }

                int number;
            if (!Int32.TryParse(testString, out number))
                return false;
               if (!(number >= 0 && number <= 255))
                {
                    Console.WriteLine("NumberCheck");
                    return false;
                }


           return IPV4(remainderString);
        }
        public Boolean IPV6(string address)
        {
            Console.WriteLine("IPV6" + "\n");
            if (address.Length == 0)
            {
                return true;
            }

            string remainderString = "";
            string testString = null;

            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == ':')
                {
                    remainderString = address.Substring(i + 1);
                    testString = address.Substring(0, i);
                    break;
                }
            }

            if (testString == null)
            {
                testString = address;
            }

            Console.WriteLine("remainder: " + remainderString);
            Console.WriteLine("test: " + testString + "\n");

            if (testString.Length > 4)
            {
                return false;
            }


            if(!(System.Text.RegularExpressions.Regex.IsMatch(testString, @"\A\b[0-9a-fA-F]+\b\Z")))
            {
                Console.WriteLine("Regex Check");
                return false;
            }

            return IPV6(remainderString);
        }
    }
}
