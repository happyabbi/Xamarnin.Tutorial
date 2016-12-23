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
        }
	}
}
