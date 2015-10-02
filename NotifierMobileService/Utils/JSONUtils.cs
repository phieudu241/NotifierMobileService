using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NotifierMobile.Models;

namespace NotifierMobile.Utils
{
    class JSONUtils
    {
        public static List<Notification> GetNotifications(string encodedString)
        {
            List<Notification> notifications = new List<Notification>();
            
            JSONObject jsons = new JSONObject(encodedString);

            switch (jsons.type)
            {
                case JSONObject.Type.OBJECT:
                    notifications.Add(createNotification(jsons));
                    break;
                case JSONObject.Type.ARRAY:
                    foreach (JSONObject jsonObject in jsons.list)
                    {
                        notifications.Add(createNotification(jsonObject));
                    }
                    break;
            }

            return notifications;
        }

        private static Notification createNotification(JSONObject jsonObject)
        {
            Notification notification = new Notification();
            notification.Id = (int)jsonObject["Id"].n;
            notification.Type = (int)jsonObject["Type"].n;
            notification.Title = jsonObject["Title"].str;
            notification.Message = jsonObject["Message"].str;
            notification.UnRead = jsonObject["UnRead"].b;
            notification.CreateDate = DateTime.Parse(jsonObject["CreateDate"].str);
            return notification;
        }

    }
}
