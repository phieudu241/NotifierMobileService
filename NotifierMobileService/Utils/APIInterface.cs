using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotifierMobile.Utils
{
    class APIInterface
    {
        //private static const string API_URL = "http://notifiermobile.com/api/notifications";
        public const string API_URL = "http://localhost:8282/api/notifications";
        public const string GET_URL = API_URL;
        public const string ADD_URL = API_URL;
        public const string UPDATE_URL = API_URL;
        public const string DELETE_URL = API_URL;
        public const string MARKREAD_URL = API_URL + "/markAsRead";
    }
}
