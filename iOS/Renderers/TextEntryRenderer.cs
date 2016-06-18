using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin_Forms_InputAccessory;
using Xamarin_Forms_InputAccessory.iOS;
using UIKit;
using CoreGraphics;


[assembly: ExportRenderer (typeof(TextEntry), typeof(TextEntryRenderer))]
namespace Xamarin_Forms_InputAccessory.iOS
{
	public class TextEntryRenderer : EntryRenderer
	{
		TextEntry _nativeUITextField;
		public TextEntryRenderer ()
		{
			

		}
		protected override void OnElementChanged (ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged (e);
			 var e2 = e.NewElement as TextEntry;
			_nativeUITextField = e2;
			if (Control != null) {
				Control.BackgroundColor = UIColor.LightGray;
				Control.BorderStyle = UITextBorderStyle.RoundedRect;
				var btnPrev = new UIBarButtonItem("Previous", UIBarButtonItemStyle.Bordered, GoToPrevious);
				btnPrev.TintColor = UIColor.White;
				var btnNext = new UIBarButtonItem("Next", UIBarButtonItemStyle.Bordered, GoToNext);
				btnNext.TintColor = UIColor.White;

				UIToolbar uiTool = new UIToolbar (new CGRect(0.0f, 0.0f, 400f, 44.0f));
				uiTool.Items = new UIBarButtonItem[]{
					btnPrev,
					btnNext,
					new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
					new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate {
						Control.ResignFirstResponder();
					})
				};
				uiTool.TintColor = UIColor.White;
				uiTool.BarStyle = UIBarStyle.Black;
				Control.InputAccessoryView = uiTool;

			}

		}
		public void GoToNext(object sender, EventArgs e)
		{
			_nativeUITextField.NextEntry.Focus();
		}
		public void GoToPrevious(object sender, EventArgs e)
		{
			_nativeUITextField.PreviousEntry.Focus();
		}

	}
}

