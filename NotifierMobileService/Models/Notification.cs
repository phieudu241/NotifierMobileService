using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotifierMobile.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public int Type { get; set; }
        public bool UnRead { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}