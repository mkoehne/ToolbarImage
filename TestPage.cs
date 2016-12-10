using System;

using Xamarin.Forms;

namespace ToolbarImage
{
	public class TestPage : ContentPage
	{
		public string Image = "ic_android_white_48dp";
		Button changeButton;

		public TestPage()
		{
			changeButton = new Button();
			changeButton.Text = "Change Toolbar image";
			changeButton.Clicked += ChangeButton_Clicked;

			Content = new StackLayout
			{
				Children = {
					changeButton
				}
			};
		}

		void ChangeButton_Clicked(object sender, EventArgs e)
		{
			if (Image == "ic_android_white_48dp")
			{
				Image = "ic_favorite_white_48dp";
			}
			else {
				Image = "ic_android_white_48dp";
			}

			this.OnPropertyChanged(this.ToString());
		}
	}
}

