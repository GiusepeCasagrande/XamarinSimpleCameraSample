using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;

namespace SimpleCameraApp
{
	public partial class SimpleCameraAppViewController : UIViewController
	{
		UIImagePickerController m_picker;

		public SimpleCameraAppViewController() : base("SimpleCameraAppViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);

			// Setup the UIImagePickerController
			m_picker = new UIImagePickerController();
			m_picker.SourceType = UIImagePickerControllerSourceType.Camera;
			m_picker.ModalPresentationStyle = UIModalPresentationStyle.CurrentContext;
			m_picker.PrefersStatusBarHidden();
			m_picker.ShowsCameraControls = false;
			m_picker.Delegate = new ImagePickerDelegate();

			// Setup the "OverlayView", basically the custom interface of the camera.
			var nibObjects = NSBundle.MainBundle.LoadNib("OverlayView", this, null);
			overlayView = (UIView)Runtime.GetNSObject(nibObjects.ValueAt(0));
			overlayView.Frame = m_picker.CameraOverlayView.Frame;
			m_picker.CameraOverlayView = overlayView;

			PresentViewController (m_picker, false, null);
		}

		partial void btnSnap(MonoTouch.UIKit.UIBarButtonItem sender)
		{
			m_picker.TakePicture();
		}

		partial void btnDone(MonoTouch.UIKit.UIBarButtonItem sender)
		{
			throw new System.NotImplementedException();
		}
	}
}

