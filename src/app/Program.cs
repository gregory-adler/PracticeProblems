using System;
using Libary;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MessageViewModel testView = new MessageViewModel();
            testView.MessageID = 4;
            testView.Subject = "Hello";
            testView.Contents = "person";
            testView.Sender = "greg";
            testView.Recipient = "another person";
            testView.Read = false;
            Message testMessage = testView.generateMessage();
            Console.WriteLine(testMessage.Contents);
        }
    }
}
