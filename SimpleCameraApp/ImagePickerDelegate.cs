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
			var documentsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string jpgFilename = System.IO.Path.Combine(documentsDirectory, string.Format("{0}.jpg", Guid.NewGuid()));

			using (NSData imageData = image.AsJPEG(0.2f))
			{
				NSError err;
				if (!imageData.Save(jpgFilename, false, out err))
				{
					Console.WriteLine("Saving of file failed: " + err.Description);
				}
			}
		}
	}
}

