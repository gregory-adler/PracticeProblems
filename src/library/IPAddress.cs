namespace Library
{
    using System.Collections.Generic;
    using System;

    public class IPAddress
    {
        public Boolean ValidIPAddress(string address)
        {
            Console.WriteLine("IPAddress: " + address + "\n");

            Boolean result;

            foreach (char letter in address){
                if (letter == '.')
                {
                    result = IPV4(address);
                    return result;
                }
                if (letter == ':')
                {
                    result = IPV6(address);
                    return result;
                }
            }
            return false;
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

            if (testString == null)
            {
                testString = address;
            }

            Boolean LeadingZeroes = true;
            for (int i = 0; i< testString.Length; i++)
            {
                // Leading Zeroes
                if (testString[i] != '0')
                {
                    LeadingZeroes = false;
                }
                if (testString[i] == '0')
                {
                    if (LeadingZeroes && i != 0)
                    {
                        Console.WriteLine("Leading Zeroes");
                        return false;
                    }
                }

                //Number check
               if (!(testString[i] >='0' && testString[i] <= '9'))
                {
                    return false;
                }

               int number = Int32.Parse(testString);
               if (!(number >= 0 && number <= 255))
                {
                    Console.WriteLine("NumberCheck");
                    return false;
                }

            }

           return IPV4(remainderString);
        }
        public Boolean IPV6(string address)
        {
            return true;
        }
    }
}
