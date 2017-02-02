namespace Libary {
    using System;

    public class Message{
        public int MessageID {get; set;}
        public string Subject{get; set;}
        public string Contents {get; set;}
        public DateTime SentTime {get; set;}
        public DateTime ModifiedTime {get; set;}
        public string Sender{get; set;}
        public string Recipient{get; set;}
        public bool Read {get; set;}
        public DateTime ReadTime {get; set;}
    }
}