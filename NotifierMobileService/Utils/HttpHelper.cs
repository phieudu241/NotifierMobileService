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
        public static WebRequest createRequest(RequestType type, IRequestModel model, int? id)
        {
            HttpRequestAttr requestAttrs = (HttpRequestAttr) type.GetAttr();
            WebRequest request;
            request = WebRequest.Create(requestAttrs.URL + "/" + id);
            request.Method = requestAttrs.Method;
            request.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = model.GenerateJsonString();
                streamWriter.Write(json);
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
