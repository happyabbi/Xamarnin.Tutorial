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

            //�]�wtitle
            this.Title = "Two";

            //�]�wStyle
            NavigationController.NavigationBar.BarStyle = UIBarStyle.Black;

            //�]�w��r�M�I����
            this.NavigationController.NavigationBar.TintColor = UIColor.Yellow;
            this.NavigationController.NavigationBar.BarTintColor = UIColor.Red;
        }
	}
}
