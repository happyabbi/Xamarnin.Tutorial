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

namespace L04
{
	[Foundation.Register("L04ViewController")]
	partial class L04ViewController
	{
		[Foundation.Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView MyTable { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (MyTable != null) {
				MyTable.Dispose ();
				MyTable = null;
			}
		}
	}
}
