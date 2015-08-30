using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotifierMobile.Models
{
    public class Authentication : IRequestModel
    {
        public string Username { get; set; }
        public string SecretKey { get; set; }

        public Authentication() { }

        public Authentication(String Username, String SecretKey)
        {
            this.Username = Username;
            this.SecretKey = SecretKey;
        }

        public string GenerateJsonString()
        {
            JSONObject json = new JSONObject();
            json.AddField("Username", Username);
            json.AddField("SecretKey", SecretKey);

            return json.Print();
        }
    }
}
