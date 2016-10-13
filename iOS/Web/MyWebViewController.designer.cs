// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Simon.iOS
{
	[Register ("MyWebViewController")]
	partial class MyWebViewController
	{
		[Outlet]
		UIKit.NSLayoutConstraint btnGO { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnGO != null) {
				btnGO.Dispose ();
				btnGO = null;
			}
		}
	}
}
