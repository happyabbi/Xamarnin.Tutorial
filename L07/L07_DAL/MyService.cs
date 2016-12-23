using L07_DAL.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace L07_DAL
{
    public class MyService
    {
        Service1Client service;

        public MyService()
        {
            //Service1Client service = new Service1Client(
            //    new BasicHttpBinding(BasicHttpSecurityMode.None),
            //    new EndpointAddress("http://xamarinclassdemo.azurewebsites.net/WebService1.asmx"));
        }

        //public Task<string> CallService(int value)
        //{
        //    TaskCompletionSource<string> task=new TaskCompletionSource<string>();
        //    service.GetDataCompleted += (sender, e) =>
        //    {
        //        task.SetResult(e.Result);
        //    };
        //    service.GetDataAsync(value);
        //    return task.Task;
        //}

    }
}
