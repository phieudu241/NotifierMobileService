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
            GetModel model = new GetModel();

            Authentication authentication = new Authentication("test", "123");
            model.Username = "test";
            model.SecretKey = "123";


            //NotifierMobileService.GetAll(authentication, null, null);
            //NotifierMobileService.Get(5, authentication);

            AddModel addModel = new AddModel();
            addModel.Title = "title";
            addModel.Message = "message";
            addModel.CreateDate = DateTime.Now;
            //NotifierMobileService.Add(authentication, addModel);
            
            UpdateModel updateModel = new UpdateModel();
            updateModel.Message = "update";
            updateModel.Title = "update";
            updateModel.Type = 2;
            //NotifierMobileService.Update(20, authentication, updateModel);

            MarkAsReadModel markModel = new MarkAsReadModel();
            markModel.Username = "test";
            markModel.SecretKey = "123";
            NotifierMobileService.MarkAsRead(5, markModel);

            NotifierMobileService.Delete(7, authentication);

        }
    }
}
