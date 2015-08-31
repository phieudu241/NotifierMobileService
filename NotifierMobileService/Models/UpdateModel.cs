using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotifierMobile.Models
{
    public class UpdateModel : IRequestModel
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public int? Type { get; set; }
        public bool? UnRead { get; set; }

        public UpdateModel() { }
        public UpdateModel(string username, string secretKey, string title, string message, int? type, bool? unread)
        {
            this.Title = title;
            this.Message = message;
            this.Type = type;
            this.UnRead = unread;
        }

        public string GenerateJsonString()
        {
            JSONObject json = new JSONObject();
            json.AddField("Title", Title);
            json.AddField("Message", Message);

            if (Type.HasValue)
            {
                json.AddField("Type", Type.Value);
            }

            if (UnRead.HasValue)
            {
                json.AddField("UnRead", UnRead.Value);
            }

            return json.Print();
        }
    }
}