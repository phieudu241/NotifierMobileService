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
            model.Username = "test";
            model.SecretKey = "123";
            NotifierMobileService.GetAll(model);
            NotifierMobileService.Get(5, model);

            AddModel addModel = new AddModel();
            addModel.Username = "test";
            addModel.SecretKey = "123";
            addModel.Title = "title";
            addModel.Message = "message";
            addModel.CreateDate = DateTime.Now;
            NotifierMobileService.Add(addModel);
            
            UpdateModel updateModel = new UpdateModel();
            updateModel.Username = "test";
            updateModel.SecretKey = "123";
            updateModel.Message = "update";
            updateModel.Title = "update";
            updateModel.Type = 2;
            //NotifierMobileService.Update(12, updateModel);

            MarkAsReadModel markModel = new MarkAsReadModel();
            markModel.Username = "test";
            markModel.SecretKey = "123";
            //NotifierMobileService.MarkAsRead(10, markModel);

            DeleteModel authentication = new DeleteModel();
            authentication.Username = "test";
            authentication.SecretKey = "123";
            //NotifierMobileService.Delete(6, authentication);

        }
    }
}
