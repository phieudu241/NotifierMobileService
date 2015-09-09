using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using NotifierMobile.Models;
using NotifierMobile.Enums;

namespace NotifierMobile.Utils
{
    class HttpHelper
    {
        public static WebRequest createGetRequest(RequestType requestType, Authentication authentication, int? id, int? type, bool? unread, int? fromId)
        {
            HttpRequestAttr requestAttrs = (HttpRequestAttr)requestType.GetAttr();
            WebRequest request;
            string url = requestAttrs.URL;
            if (id.HasValue)
            {
                url += ("/" + id);
            }

            url += "?username=" + authentication.Username + "&secretKey=" + authentication.SecretKey;

            if (type.HasValue)
            {
                url += "&type=" + type.Value;
            }

            if (unread.HasValue)
            {
                url += "&unread=" + unread.Value;
            }

            if (fromId.HasValue)
            {
                url += "&fromId=" + fromId.Value;
            }

            request = WebRequest.Create(url);
            request.Method = requestAttrs.Method;

            return request;
        }
        
        public static WebRequest createRequest(RequestType type, Authentication authentication, int? id, IRequestModel model)
        {
            HttpRequestAttr requestAttrs = (HttpRequestAttr) type.GetAttr();
            WebRequest request;
            string url = requestAttrs.URL;
            if (id.HasValue)
            {
                url += ("/" + id);
            }

            url += "?username=" + authentication.Username + "&secretKey=" + authentication.SecretKey;

            request = WebRequest.Create(url);
            request.Method = requestAttrs.Method;
            if (model != null)
            {
                request.ContentType = "application/json";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = model.GenerateJsonString();
                    streamWriter.Write(json);
                }    
            }
            

            return request;
        }

        public static List<Notification> getResponse(WebRequest request)
        {
            List<Notification> notifications = new List<Notification>();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();
                if (!String.IsNullOrEmpty(result))
                {
                    notifications = JSONUtils.GetNotifications(result);
                }
            }

            return notifications;
        }
    }
}
