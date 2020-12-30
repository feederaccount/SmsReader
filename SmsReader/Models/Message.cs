using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmsReader.Models
{
    public class Message
    {
        public string Sender { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Date { get; set; }
        public string Body { get; set; }

        public string Type { get; set; }
        
        public bool SentByMe
        {
            get
            {
                if(this.PhoneNumber == "07758264458" ||
                   this.PhoneNumber == "+447758264458" ||
                   this.Type == "2")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Message() { }
    }
}