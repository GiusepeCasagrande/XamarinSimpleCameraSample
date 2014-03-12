// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace SimpleCameraApp
{
	[Register ("SimpleCameraAppViewController")]
	partial class SimpleCameraAppViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIView overlayView { get; set; }

		[Action ("btnDone:")]
		partial void btnDone (MonoTouch.UIKit.UIBarButtonItem sender);

		[Action ("btnSnap:")]
		partial void btnSnap (MonoTouch.UIKit.UIBarButtonItem sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (overlayView != null) {
				overlayView.Dispose ();
				overlayView = null;
			}
		}
	}
}
