using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotifierMobile.Exceptions
{
    class NotificationException : Exception
    {
        private int httpStatus { get ; set; }
        public string errorMessage { get; set; }

        public NotificationException(int httpStatus)
        {
            this.httpStatus = httpStatus;
        }

        public NotificationException(string errorMessage)
        {
            httpStatus = -1;
            this.errorMessage = errorMessage;
        }

        public NotificationException(int httpStatus, string errorMessage)
        {
            this.httpStatus = httpStatus;
            this.errorMessage = errorMessage;
        }
    }
}
