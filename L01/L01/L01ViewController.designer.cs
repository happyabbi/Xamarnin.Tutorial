// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace L01
{
    [Register ("L01ViewController")]
    partial class L01ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel My { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MyButton { get; set; }

        [Action ("MyButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void MyButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (My != null) {
                My.Dispose ();
                My = null;
            }

            if (MyButton != null) {
                MyButton.Dispose ();
                MyButton = null;
            }
        }
    }
}