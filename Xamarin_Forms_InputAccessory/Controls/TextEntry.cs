using System;
using Xamarin.Forms;

namespace Xamarin_Forms_InputAccessory
{
	public class TextEntry : Entry
	{
		public Entry NextEntry { get; set; }
		public Entry PreviousEntry { get; set; }

		public TextEntry()
		{
		}
	}
}

