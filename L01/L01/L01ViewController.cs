using System;
using CoreGraphics;

using Foundation;
using UIKit;

namespace L01
{
    public partial class L01ViewController : UIViewController
    {
        public L01ViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //lab:新增一個View，並新增一個ViewController:MyViewController
            //lab:並將MyViewController設為起始畫面
            //lab:新增一個xib controller命名為TestViewController 開啓在下方的UIButton28_TouchUpInside註解
            //lab:在新增的TestViewController畫面中新增一個Button，設定為Action並使用this.DismissViewController
            //lab:觀察生命週期變化
            Console.WriteLine("=====ViewDidLoad=====");
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            Console.WriteLine("=====ViewWillAppear=====");
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            Console.WriteLine("=====ViewDidAppear=====");

        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            Console.WriteLine("=====ViewWillDisappear=====");
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
            Console.WriteLine("=====ViewDidDisappear=====");
        }


 

        partial void MyButton_TouchUpInside(UIButton sender)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}