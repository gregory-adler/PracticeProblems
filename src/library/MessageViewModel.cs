namespace Libary {
    using System;

    public class MessageViewModel {
        public int MessageID {get; set;}
        public string Subject{get; set;}
        public string Contents {get; set;}
        public DateTime SentTime {get; set;} = DateTime.Now;
        public DateTime ModifiedTime {get; set;}
        public string Sender{get; set;}
        public string Recipient{get; set;}
        public bool Read {get; set;}
        public DateTime ReadTime {get; set;}

        public Message MessageToSend{get; set;}

        public Message generateMessage(){
            MessageToSend = new Message();
            MessageToSend.MessageID = MessageID;
            MessageToSend.Subject = Subject;
            MessageToSend.Contents = Contents;
            MessageToSend.SentTime = SentTime;
            MessageToSend.ModifiedTime = ModifiedTime;
            MessageToSend.Sender = Sender;
            MessageToSend.Recipient = Recipient;
            MessageToSend.Read = Read;
            MessageToSend.ReadTime = ReadTime;
            return MessageToSend;
        }

    }
}