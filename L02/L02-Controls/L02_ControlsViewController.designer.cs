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

namespace L02_Controls
{
	[Foundation.Register("L02ControlsViewController")]
	partial class L02ControlsViewController
	{
		[Foundation.Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnClick { get; set; }

		[Foundation.Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblText { get; set; }

		[Foundation.Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView MyView { get; set; }

		[Foundation.Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISegmentedControl seg { get; set; }

		[Foundation.Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtField { get; set; }

		[Foundation.Action("UIButton41_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton41_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnClick != null) {
				btnClick.Dispose ();
				btnClick = null;
			}
			if (lblText != null) {
				lblText.Dispose ();
				lblText = null;
			}
			if (MyView != null) {
				MyView.Dispose ();
				MyView = null;
			}
			if (seg != null) {
				seg.Dispose ();
				seg = null;
			}
			if (txtField != null) {
				txtField.Dispose ();
				txtField = null;
			}
		}
	}
}
