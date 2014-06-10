using System;
using Xamarin.Forms;

namespace AdaptiveContentSample
{
	public class AdaptiveContentPage : ContentPage
	{
		public AdaptiveContentPage (View portraitLayout, View landscapeLayout)
		{
			PortraitLayout = portraitLayout;
			LandscapeLayout = landscapeLayout;

			this.SizeChanged += HandleSizeChanged;
		}

		public View PortraitLayout { get; private set; }
		public View LandscapeLayout { get; private set; }

		void HandleSizeChanged (object sender, EventArgs e)
		{
			this.Content = Width > Height ? LandscapeLayout : PortraitLayout;
		}
			
		public void SetLayouts(View portraitLayout, View landscapeLayout)
		{
			this.PortraitLayout = portraitLayout;
			this.LandscapeLayout = landscapeLayout;
		}
	}
}

