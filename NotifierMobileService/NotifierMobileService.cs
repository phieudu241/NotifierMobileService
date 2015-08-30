using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using NotifierMobile.Models;
using System.IO;
using System.Collections.Specialized;
using NotifierMobile.Utils;
using NotifierMobile.Enums;

namespace NotifierMobile
{
    public class NotifierMobileService
    {
        /// <summary>
        /// Get notifications by type or unread
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static List<Notification> GetAll(GetModel model)
        {
            List<Notification> notifications = new List<Notification>();
            try
            {
                WebRequest request = HttpHelper.createRequest(RequestType.GET_ALL, model, null);
                notifications = HttpHelper.getResponse(request);
            }
            catch (WebException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            
            return notifications;
        }

        /// <summary>
        /// Get notification by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static Notification Get(int id, GetModel model)
        {
            List<Notification> notifications = new List<Notification>();
            try
            {
                WebRequest request = HttpHelper.createRequest(RequestType.GET, model, id);
                notifications = HttpHelper.getResponse(request);
            }
            catch (WebException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            
            return notifications[0];
        }

        /// <summary>
        /// Add a new notification
        /// </summary>
        /// <param name="model"></param>
        public static void Add(AddModel model)
        {
            try
            {
                WebRequest request = HttpHelper.createRequest(RequestType.ADD, model, null);
                HttpHelper.getResponse(request);
            }
            catch (WebException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Update a notification by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        public static void Update(int id, UpdateModel model)
        {
            try
            {
                WebRequest request = HttpHelper.createRequest(RequestType.UPDATE, model, id);
                HttpHelper.getResponse(request);
            }
            catch (WebException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        
        /// <summary>
        /// Delete a notification by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        public static void Delete(int id, DeleteModel model)
        {
            try
            {
                WebRequest request = HttpHelper.createRequest(RequestType.DELETE, model, id);
                HttpHelper.getResponse(request);
            }
            catch (WebException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Mark a notification as read
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        public static void MarkAsRead(int id, MarkAsReadModel model)
        {
            try
            {
                WebRequest request = HttpHelper.createRequest(RequestType.MARK_AS_READ, model, id);
                HttpHelper.getResponse(request);
            }
            catch (WebException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
