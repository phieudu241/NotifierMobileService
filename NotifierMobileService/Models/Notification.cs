using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotifierMobile.Models
{
    public class Notification
    {
        public Int32 Id { get; set; }
        public String Title { get; set; }
        public String Message { get; set; }
        public Int32 Type { get; set; }
        public Boolean UnRead { get; set; }
        public DateTime CreateDate { get; set; }

        public Notification()
        {
        }

        public Notification(String Title, String Message)
        {
            this.Title = Title;
            this.Message = Message;
        }

        public Notification(String Title, String Message, Int32 Type)
        {
            this.Title = Title;
            this.Message = Message;
            this.Type = Type;
        }

        public Notification(String Title, String Message, Int32 Type, DateTime CreateDate)
        {
            this.Title = Title;
            this.Message = Message;
            this.Type = Type;
            this.CreateDate = CreateDate;
        }

        public string GenerateJsonString()
        {
            JSONObject json = new JSONObject();
            if (Id != null)
            {
                json.AddField("Id", Id);    
            }

            if (Title != null)
            {
                json.AddField("Title", Title);
            }

            if (Message != null)
            {
                json.AddField("Message", Message);
            }

            if (Type != null)
            {
                json.AddField("Type", Type);
            }

            if (CreateDate != null)
            {
                json.AddField("CreateDate", CreateDate.ToString());
            }

            return json.Print();
        }
    }
}