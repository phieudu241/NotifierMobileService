using System;

namespace NotifierMobile.Models
{
    public class Notification
    {
        public int? Id { get; set; }
        public String Title { get; set; }
        public String Message { get; set; }
        public int? Type { get; set; }
        public bool? UnRead { get; set; }
        public DateTime CreateDate { get; set; }

        public Notification()
        {
        }

        public Notification(String Title, String Message)
        {
            this.Title = Title;
            this.Message = Message;
        }

        public Notification(String Title, String Message, int Type)
        {
            this.Title = Title;
            this.Message = Message;
            this.Type = Type;
        }

        public Notification(String Title, String Message, int Type, DateTime CreateDate)
        {
            this.Title = Title;
            this.Message = Message;
            this.Type = Type;
            this.CreateDate = CreateDate;
        }

        public string GenerateJsonString()
        {
            JSONObject json = new JSONObject();
            if (Id.HasValue)
            {
                json.AddField("Id", Id.Value);    
            }

            if (Title != null)
            {
                json.AddField("Title", Title);
            }

            if (Message != null)
            {
                json.AddField("Message", Message);
            }

            if (Type.HasValue)
            {
                json.AddField("Type", Type.Value);
            }

            if (UnRead.HasValue)
            {
                json.AddField("UnRead", UnRead.Value);
            }

            if (CreateDate != null)
            {
                json.AddField("CreateDate", CreateDate.ToString());
            }

            return json.Print();
        }
    }
}