using System;
using Android.App;
using Android.Graphics.Drawables;
using Android.Support.V4.Content;
using Android.Widget;
using ToolbarImage;
using ToolbarImage.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TestPage), typeof(TestPageRenderer))]

namespace ToolbarImage.Droid
{
	public class TestPageRenderer : PageRenderer
	{
		TestPage page;
		ImageView imageView;
		Activity activity;

		protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (imageView != null)
			{
				var drawableImage = ContextCompat.GetDrawable(activity, Resources.GetIdentifier(page.Image, "drawable", activity.PackageName));
				var bitmap = (drawableImage as BitmapDrawable).Bitmap;
				if (bitmap != null)
				{
					imageView.SetImageBitmap(bitmap);
				}
			}
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
		{
			base.OnElementChanged(e);

			if (e.OldElement != null || Element == null)
			{
				return;
			}

			page = e.NewElement as TestPage;
			activity = this.Context as Activity;
			imageView = (ImageView)activity.FindViewById(Resource.Id.toolbar_logo);

			if (imageView != null)
			{
				var drawableImage = ContextCompat.GetDrawable(activity, Resources.GetIdentifier(page.Image, "drawable", activity.PackageName));
				var bitmap = (drawableImage as BitmapDrawable).Bitmap;
				if (bitmap != null)
				{
					imageView.SetImageBitmap(bitmap);
				}
			}
		}
	}
}
