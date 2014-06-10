using System;
using Xamarin.Forms;

namespace AdaptiveContentSample
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			var portraitLayout = new ContentView {
				Content = new StackLayout {
					Orientation = StackOrientation.Vertical,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					Children = { 
						new Label { Text = "First" }, 
						new Label { Text = "Second" }, 
						new Label { Text = "Third" } 
					}
				}
			};

			var landscapeLayout = new ContentView {
				Content = new StackLayout {
					HorizontalOptions = LayoutOptions.CenterAndExpand,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					Orientation = StackOrientation.Horizontal,
					Children = { 
						new Label { Text = "First" }, 
						new Label { Text = "Second" }, 
						new Label { Text = "Third" } 
					}
				}

			};
				
			return new AdaptiveContentPage (portraitLayout, landscapeLayout);
		}
	}
}

