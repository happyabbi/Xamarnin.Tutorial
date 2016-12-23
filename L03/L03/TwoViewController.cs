using Foundation;
using UIKit;
using System;
using System.CodeDom.Compiler;

namespace L03
{
	partial class TwoViewController : UIViewController
	{
        public string Value { get; set; }
		public TwoViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            this.MyLabel.Text = this.Value;

            //設定title
            this.Title = "Two";

            //設定Style
            NavigationController.NavigationBar.BarStyle = UIBarStyle.Black;

            //設定文字和背景色
            this.NavigationController.NavigationBar.TintColor = UIColor.Yellow;
            this.NavigationController.NavigationBar.BarTintColor = UIColor.Red;
        }
	}
}
