using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NotifierMobile;
using NotifierMobile.Models;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Authentication authentication = new Authentication("test", "123");

            NotifierMobileService.GetAll(authentication, null, null, null);
            NotifierMobileService.Get(5, authentication);

            AddModel addModel = new AddModel();
            addModel.Title = "title";
            addModel.Message = "message";
            addModel.CreateDate = DateTime.Now;
            NotifierMobileService.Add(authentication, addModel);
            
            UpdateModel updateModel = new UpdateModel();
            updateModel.Message = "update";
            updateModel.Title = "update";
            updateModel.Type = 2;
            NotifierMobileService.Update(20, authentication, updateModel);

            NotifierMobileService.MarkAsRead(5, authentication);

            NotifierMobileService.Delete(31, authentication);

        }
    }
}
