// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using UIKit;
using System;
using System.CodeDom.Compiler;

namespace L01
{
	[Foundation.Register("L01ViewController")]
	partial class L01ViewController
	{
		[Foundation.Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel My { get; set; }

		[Foundation.Action("UIButton28_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton28_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (My != null) {
				My.Dispose ();
				My = null;
			}
		}
	}
}
