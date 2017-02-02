namespace Libary {
    using System;

    public class MessageViewModel {
        public int MessageID {get; set;}
        public string Subject{get; set;}
        public string Contents {get; set;}
        public DateTime SentTime {get; set;}
        public DateTime ModifiedTime {get; set;}
        public string Sender{get; set;}
        public string Recipient{get; set;}
        public bool Read {get; set;}
        public DateTime ReadTime {get; set;}

        public Message Message{get; set;}

        public Message generateMessage(){
            this.Message = new Message();
            this.Message.MessageID = this.MessageID;
            this.Message.Subject = this.Subject;
            this.Message.Contents = this.Contents;
            this.Message.SentTime = this.SentTime;
            this.Message.ModifiedTime = this.ModifiedTime;
            this.Message.Sender = this.Sender;
            this.Message.Recipient = this.Recipient;
            this.Message.Read = this.Read;
            this.Message.ReadTime = this.ReadTime;
            return this.Message;
        }

    }
}