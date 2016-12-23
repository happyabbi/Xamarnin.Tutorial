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

namespace L08
{
	[Foundation.Register("L08ViewController")]
	partial class L08ViewController
	{
		[Foundation.Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnCall { get; set; }

		[Foundation.Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblAddress { get; set; }

		[Foundation.Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblFound { get; set; }

		[Foundation.Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblName { get; set; }

		[Foundation.Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView lblResult { get; set; }

		[Foundation.Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblTel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnCall != null) {
				btnCall.Dispose ();
				btnCall = null;
			}
			if (lblAddress != null) {
				lblAddress.Dispose ();
				lblAddress = null;
			}
			if (lblFound != null) {
				lblFound.Dispose ();
				lblFound = null;
			}
			if (lblName != null) {
				lblName.Dispose ();
				lblName = null;
			}
			if (lblResult != null) {
				lblResult.Dispose ();
				lblResult = null;
			}
			if (lblTel != null) {
				lblTel.Dispose ();
				lblTel = null;
			}
		}
	}
}
