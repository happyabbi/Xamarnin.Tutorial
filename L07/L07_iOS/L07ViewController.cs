using System;
using CoreGraphics;

using Foundation;
using UIKit;
using L07_DAL;

namespace L07
{
    public partial class L07ViewController : UIViewController
    {
        public L07ViewController(IntPtr handle)
            : base(handle)
        {
        }

        //lab:建立PCL專案
        //lab:在PCL中加入WebService 
        //lab:http://xamarinclassdemo.azurewebsites.net/WebService1.asmx
        //lab:將WebService方法封裝成TAP
        //tip:      new BasicHttpBinding(BasicHttpSecurityMode.None);
       //            new EndpointAddress("http://xamarinclassdemo.azurewebsites.net/WebService1.asmx");

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //lab:用Button註冊TouchUpInside事件呼叫WebService，將返回值設回lblResult
            MyService service = new MyService();
            btnCall.TouchUpInside += (sender, e) =>
            {

            };

        }

   
    }
}