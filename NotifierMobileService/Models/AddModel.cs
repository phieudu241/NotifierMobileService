using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotifierMobile.Models
{
    public class AddModel : IRequestModel
    {
        public string Username { get; set; }
        public string SecretKey { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public int? Type { get; set; }
        public DateTime? CreateDate { get; set; }

        public AddModel() { }
        public AddModel(string username, string secretKey, string title, string message, int? type, DateTime? createDate)
        {
            this.Username = username;
            this.SecretKey = secretKey;
            this.Title = title;
            this.Message = message;
            this.Type = type;
            this.CreateDate = createDate;
        }

        public string GenerateJsonString()
        {
            JSONObject json = new JSONObject();
            json.AddField("Username", Username);
            json.AddField("SecretKey", SecretKey);
            json.AddField("Title", Title);
            json.AddField("Message", Message);
            
            if (Type.HasValue)
            {
                json.AddField("Type", Type.Value);
            }

            if (CreateDate.HasValue)
            {
                json.AddField("CreateDate", CreateDate.Value.ToString());
            }

            return json.Print();
        }
    }
}