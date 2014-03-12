using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace SimpleCameraApp
{
	public class ImagePickerDelegate : UIImagePickerControllerDelegate
	{
		public ImagePickerDelegate()
		{
		}

		public override void FinishedPickingImage(UIImagePickerController picker, UIImage image, NSDictionary editingInfo)
		{
			// Here you can do anything with the image... save for example.
		}
	}
}

