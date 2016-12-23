using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;

namespace L02_Controls
{
	partial class MyViewController : UIViewController
	{
		public MyViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

        //    datePick.MaximumDate = DateTime.Now.AddDays(7);
         //   datePick.MinimumDate = DateTime.Now.AddDays(-7);

            MyWebView.LoadRequest(new NSUrlRequest(new NSUrl("http://www.thinkpower.com.tw")));
        }

        partial void UIButton170_TouchUpInside(UIButton sender)
        {
            UIAlertView alert =
                new UIAlertView("選擇時間",
                    DateTime.SpecifyKind(this.datePick.Date, DateTimeKind.Unspecified).ToString("yyyy/MM/dd"),
                     null, "確定", null);
            alert.Show();
        }



        partial void UIButton174_TouchUpInside(UIButton sender)
        {
            UIAlertView alert =
           new UIAlertView("標題", "多個按鈕", null, "OK",
               new string[] { "取消" });
            alert.Show();

            alert.Clicked += (obj, e) =>
            {
                sender.SetTitle("Button " + (int)e.ButtonIndex + " clicked", UIControlState.Normal);
                   
            };

        }
	}
}
