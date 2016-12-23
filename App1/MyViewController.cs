using Foundation;
using System;
using UIKit;

namespace App1
{
    public partial class MyViewController : UIViewController
    {
        public MyViewController (IntPtr handle) : base (handle)
        {
           
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            MyButton2.TouchUpInside += MyButton2_TouchUpInside;
             
        }

        private void MyButton2_TouchUpInside(object sender, EventArgs e)
        {
            MyButton2.SetTitle("Clicked", UIControlState.Normal);
        }
    }
}