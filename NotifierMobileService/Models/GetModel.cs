using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotifierMobile.Models
{
    public class GetModel : IRequestModel
    {
        public string Username { get; set; }
        public string SecretKey { get; set; }
        public int? Type { get; set; }
        public bool? UnRead { get; set; }

        public GetModel() { }
        public GetModel(string username, string secretKey, int? type, bool? unread)
        {
            this.Username = username;
            this.SecretKey = secretKey;
            this.Type = type;
            this.UnRead = unread;
        }

        public string GenerateJsonString()
        {
            JSONObject json = new JSONObject();
            json.AddField("Username", Username);
            json.AddField("SecretKey", SecretKey);
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