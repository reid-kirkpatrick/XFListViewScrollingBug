using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ScrollingBug
{
	public partial class MainPage : ContentPage
	{
		public static string DisableScrollMessage { get; } = "DisableScroll";

		public List<string> Items { get; } = new List<string>();

		public MainPage()
		{
			InitItems();
			InitializeComponent();
			ToolbarItems.Add(new ToolbarItem("Disable Scroll", null, () =>
			{
				MessagingCenter.Send(this, DisableScrollMessage);
			}));
		}

		private void InitItems()
		{
			var random = new Random();
			for (int i = 0; i < 50; i++)
			{
				var value = $"ListView Scroll Bug Row {i}";
				var sb = new StringBuilder();
				for (int j = 0; j < random.Next(10); j++)
				{
					sb.AppendLine(value);
				}

				sb.Append(value);
				Items.Add(sb.ToString());
			}
		}
	}
}
