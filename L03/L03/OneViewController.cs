using Foundation;
using UIKit;
using System;
using System.CodeDom.Compiler;

namespace L03
{
	partial class OneViewController : UIViewController
	{
        public string Value { get; set; }
        public OneViewController(IntPtr handle)
            : base(handle)
		{
		}

        public override void ViewDidLoad()
        {
            this.MyLabel.Text = this.Value;

            NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(UIBarButtonSystemItem.Refresh,
               (sender, e) =>
               {
                   NavigationController.PopViewController(true);
               }), true);



            NavigationItem.SetLeftBarButtonItem(new UIBarButtonItem("Back", UIBarButtonItemStyle.Plain,
                (sender, e) =>
                {
                    NavigationController.PopViewController(true);
                }), true);
            
            //設定title
            this.Title = "One";

            //設定Style
            NavigationController.NavigationBar.BarStyle = UIBarStyle.BlackTranslucent;

            //設定文字和背景色
            this.NavigationController.NavigationBar.TintColor = UIColor.Blue;
            this.NavigationController.NavigationBar.BarTintColor = UIColor.Brown;
        }
	}
}
