using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NotifierMobile;
using NotifierMobile.Models;
using NotifierMobile.Enums;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Authentication authentication = new Authentication("test", "12345");

            NotifierMobileService.GetAll(authentication, null, null, null);
            NotifierMobileService.Get(5, authentication);

            Notification addModel = new Notification();
            addModel.Title = "title";
            addModel.Message = "message";
            addModel.Type = (int) NotificationType.INFO;
            addModel.CreateDate = DateTime.Now;
            NotifierMobileService.Add(addModel, authentication);

            Notification updateModel = new Notification();
            updateModel.Message = "update";
            updateModel.Title = "update";
            updateModel.Type = 2;

            NotifierMobileService.Update(5, updateModel, authentication);

            NotifierMobileService.MarkAsRead(5, authentication);

            NotifierMobileService.Delete(90, authentication);

        }
    }
}
