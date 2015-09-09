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
        /// Get notifications by type
        /// </summary>
        /// <param name="authentication"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static List<Notification> GetAll(Authentication authentication, int type)
        {
            return GetAll(authentication, type, null, null);
        }

        /// <summary>
        /// Get notifications by unread
        /// </summary>
        /// <param name="authentication"></param>
        /// <param name="unread"></param>
        /// <returns></returns>
        public static List<Notification> GetAll(Authentication authentication, bool unread)
        {
            return GetAll(authentication, null, unread, null);
        }
        
        /// <summary>
        /// Get notifications by type and unread
        /// </summary>
        /// <param name="authentication"></param>
        /// <param name="type"></param>
        /// <param name="unread"></param>
        /// <param name="fromId"></param>
        /// <returns></returns>
        public static List<Notification> GetAll(Authentication authentication, int? type, bool? unread, int? fromId)
        {
            List<Notification> notifications = new List<Notification>();
            try
            {
                WebRequest request = HttpHelper.createGetRequest(RequestType.GET_ALL, authentication, null, type, unread, fromId);
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
        public static Notification Get(int id, Authentication authentication)
        {
            List<Notification> notifications = new List<Notification>();
            try
            {
                WebRequest request = HttpHelper.createGetRequest(RequestType.GET, authentication, id, null, null, null);
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
        public static void Add(Authentication authentication, AddModel model)
        {
            try
            {
                WebRequest request = HttpHelper.createRequest(RequestType.ADD, authentication, null, model);
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
        public static void Update(int id, Authentication authentication, UpdateModel model)
        {
            try
            {
                WebRequest request = HttpHelper.createRequest(RequestType.UPDATE, authentication, id, model);
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
        public static void Delete(int id, Authentication authentication)
        {
            try
            {
                WebRequest request = HttpHelper.createRequest(RequestType.DELETE, authentication, id, null);
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
        public static void MarkAsRead(int id, Authentication authentication)
        {
            try
            {
                WebRequest request = HttpHelper.createRequest(RequestType.MARK_AS_READ, authentication, id, null);
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
