using System;
using CoreGraphics;

using Foundation;
using UIKit;
using L08_DAL;


namespace L08
{
    public partial class L08ViewController : UIViewController
    {
        public L08ViewController(IntPtr handle)
            : base(handle)
        {
        }

        //lab:將PCL專案dll加入參考

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //lab:註冊btnCall的TouchUpInside事件，呼叫PCL中的類別，將結果回傳並顯示於畫面

            btnCall.TouchUpInside += async (s,e) => {

            };
        }
       
    }
}