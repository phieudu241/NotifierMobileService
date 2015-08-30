using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotifierMobile.Utils
{
    class APIInterface
    {
        //private static const string API_URL = "http://notifiermobile.com/api/notifier";
        public const string API_URL = "http://localhost:8282/api/notifier";
        public const string GET_URL = API_URL + "/get";
        public const string ADD_URL = API_URL + "/add";
        public const string UPDATE_URL = API_URL + "/update";
        public const string DELETE_URL = API_URL + "/delete";
        public const string MARKREAD_URL = API_URL + "/markRead";
    }
}
