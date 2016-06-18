using System;

using Xamarin.Forms;

namespace Xamarin_Forms_InputAccessory.iOS
{
	public class TextEntryRenderer : ContentPage
	{
		public TextEntryRenderer()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


