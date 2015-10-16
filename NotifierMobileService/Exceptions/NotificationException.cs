using System;

namespace NotifierMobile.Exceptions
{
    class NotificationException : Exception
    {
        private int httpStatus { get ; set; }
        public string errorMessage { get; set; }
        public Exception exception { get; set; }

        public NotificationException(int httpStatus)
        {
            this.httpStatus = httpStatus;
        }

        public NotificationException(string errorMessage)
        {
            httpStatus = -1;
            this.errorMessage = errorMessage;
        }

        public NotificationException(string errorMessage, Exception exception)
        {
            httpStatus = -1;
            this.errorMessage = errorMessage;
            this.exception = exception;
        }

        public NotificationException(int httpStatus, string errorMessage)
        {
            this.httpStatus = httpStatus;
            this.errorMessage = errorMessage;
        }
    }
}
