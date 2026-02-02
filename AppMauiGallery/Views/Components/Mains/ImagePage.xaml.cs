namespace AppMauiGallery.Views.Components.Mains;

public partial class ImagePage : ContentPage
{
	public ImagePage()
	{
		InitializeComponent();
        /*
		 Image.source pode ter 4 valores
			- ImageSource.FromFile
			- ImageSource.FromResource
			- ImageSource.FromStream
			- ImageSource.FromUri(new Uri (http://...))
		 */
    }
}