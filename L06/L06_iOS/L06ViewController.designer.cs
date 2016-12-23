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
	[Register ("L06ViewController")]
	partial class L06ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnAdd { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnQuery { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField lblName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tableData { get; set; }

		[Action ("btnQuery_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnQuery_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnAdd != null) {
				btnAdd.Dispose ();
				btnAdd = null;
			}
			if (btnQuery != null) {
				btnQuery.Dispose ();
				btnQuery = null;
			}
			if (lblName != null) {
				lblName.Dispose ();
				lblName = null;
			}
			if (tableData != null) {
				tableData.Dispose ();
				tableData = null;
			}
		}
	}
}
