// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System;
using System.CodeDom.Compiler;

namespace L06
{
	[Register ("AddViewController")]
	partial class AddViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnAdd { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtAge { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtName { get; set; }

		[Action ("btnAdd_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnAdd_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnAdd != null) {
				btnAdd.Dispose ();
				btnAdd = null;
			}
			if (txtAge != null) {
				txtAge.Dispose ();
				txtAge = null;
			}
			if (txtName != null) {
				txtName.Dispose ();
				txtName = null;
			}
		}
	}
}
