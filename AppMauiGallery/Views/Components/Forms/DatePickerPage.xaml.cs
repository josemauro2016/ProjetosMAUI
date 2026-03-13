namespace AppMauiGallery.Views.Components.Forms;

public partial class DatePickerPage : ContentPage
{
	public DatePickerPage()
	{
		InitializeComponent();
	}

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
		LblValue.Text = $"Data selecionada: {e.NewDate.ToString()}";
    }
}