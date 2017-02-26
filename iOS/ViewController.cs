using System;
using CoreGraphics;
using UIKit;



namespace ConvertNow.iOS
{
	public partial class ViewController : UIViewController
	{
		int noOfbuttons = 16;
		UIButton scrollButton;
		UIButton selectedButton;
		UILabel label;

		public ViewController(IntPtr handle) : base(handle)
		{
		}


		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			selectedButton = new UIButton();
			label = new UILabel();
			addButtonsToScrollView(noOfbuttons);
		}

		private void addButtonsToScrollView(int count)
		{
			for (int index = 0; index < count; index = index + 1)
			{
				scrollButton = new UIButton();
				scrollButton.Frame = new CGRect(0 + (index * 56), 0, 56, 50);
				scrollButton.Tag = index;
				if (index == 0)
				{
					selectedButton = scrollButton;
				}
				scrollButton.TouchUpInside += HandleEventHandler;
				string indexString = index.ToString();
				scrollButton.BackgroundColor = UIColor.Red;
				scrollButton.SetImage(UIImage.FromBundle(indexString), UIControlState.Normal);
				scrollView.AddSubview(scrollButton);
			}
			scrollView.ScrollEnabled = true;
			label.BackgroundColor = UIColor.White;
			scrollView.AddSubview(label);
			selectedButton.SendActionForControlEvents(UIControlEvent.TouchUpInside);
			var size = new CGSize(56 * noOfbuttons, 50);
			scrollView.ContentSize = size;
		}


		protected void HandleEventHandler(object sender, EventArgs e)
		{
			var senderButton = (UIButton)sender;
			selectedButton.BackgroundColor = UIColor.Red;
			selectedButton = senderButton;
			label.Frame = new CGRect(senderButton.Frame.X, 47, senderButton.Frame.Size.Width, 3);
			scrollView.AddSubview(label);
			foreach (var view in scrollView.Subviews)
			{
				if (view is UIButton && view.Tag == senderButton.Tag)
				{
					if (senderButton.Tag > 12)
					{
						scrollView.SetContentOffset(new CGPoint(scrollView.ContentSize.Width - UIScreen.MainScreen.Bounds.Width, scrollView.ContentOffset.Y), true);
					}
					else
					{
						var xCenter = Math.Max(0, (view.Center.X - scrollView.Frame.Width / 2));
						scrollView.SetContentOffset(new CGPoint(xCenter, scrollView.ContentOffset.Y), true);
					}
					break;
				}
			}
			var co = new CommonUtils();
			titleLabel.Text = co.displayText((int)senderButton.Tag);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
		}


	}
}
