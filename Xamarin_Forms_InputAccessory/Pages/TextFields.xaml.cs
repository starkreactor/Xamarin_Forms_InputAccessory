using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Xamarin_Forms_InputAccessory
{
	public partial class TextFields : ContentPage
	{
		public TextFields()
		{
			InitializeComponent();
		}
		private TextEntry entry1;
		private TextEntry entry2;
		private TextEntry entry3;
		protected override void OnAppearing()
		{
			entry1 = new TextEntry
			{
				Text = "Field 1"
			};
			entry2 = new TextEntry
			{
				Text = "Field 2"
			};
			entry3 = new TextEntry
			{
				Text = "Field 3"
			};
			entry1.NextEntry = entry2;
			entry2.NextEntry = entry3;
			entry3.NextEntry = entry1;
			entry1.PreviousEntry = entry3;
			entry2.PreviousEntry = entry1;
			entry3.PreviousEntry = entry2;

			Content = new StackLayout
			{
				Children = { entry1, entry2, entry3 },
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};
		}
	}
}

