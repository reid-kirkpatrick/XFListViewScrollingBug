using ScrollingBug.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ListView), typeof(CustomListViewRenderer))]
namespace ScrollingBug.iOS
{
	public class CustomListViewRenderer : ListViewRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
		{
			base.OnElementChanged(e);

			MessagingCenter.Instance.Subscribe<MainPage>(this, MainPage.DisableScrollMessage, x => Control.ScrollEnabled = !Control.ScrollEnabled);
		}
	}
}