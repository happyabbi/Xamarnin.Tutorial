using System;
using CoreGraphics;

using Foundation;
using UIKit;

namespace L03
{
    public partial class L03ViewController : UIViewController
    {
        public L03ViewController(IntPtr handle)
            : base(handle)
        {
            //lab:在畫面上加入NavigationController並設定rootView

            //lab:使用拖曳方式按下One讓Root轉換至One
            
            //lab:將One Two連線
          
        }

        //lab覆寫PrepareForSegue，判斷是要去One或Two，並給予參數值segue.Identifier



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
            this.Title = "Orz";

            //lab:使用程式碼的方式按下Two By Code讓Root轉換至Two
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion


    }
}