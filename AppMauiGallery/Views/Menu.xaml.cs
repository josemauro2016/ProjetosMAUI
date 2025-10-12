using AppMauiGallery.Repositories;

namespace AppMauiGallery.Views;

public partial class Menu : ContentPage
{
    public Menu()
    {
        InitializeComponent();
        var categories = new CategoryRepository().GetCategories();

        foreach (var category in categories)
        {
            var lblCategory = new Label();
            lblCategory.Text = category.Name;
            lblCategory.FontFamily = "OpenSansSemibold";
            lblCategory.TextColor = Colors.Black;
            
            MenuContainer.Children.Add(lblCategory);
            foreach (var component in category.Components)
            {
                var tap = new TapGestureRecognizer();
                tap.CommandParameter = component.Page;
                tap.Tapped += OnTapComponent;

                var lblComponentTitle = new Label();
                lblComponentTitle.Text = component.Title;
                lblComponentTitle.FontFamily = "OpenSansSemibold";
                lblComponentTitle.TextColor = Colors.Black;
                lblComponentTitle.Margin = new Thickness(20, 20, 0, 0);
                lblComponentTitle.GestureRecognizers.Add(tap);

                var lblComponentDescription = new Label();
                lblComponentDescription.Text = component.Description;
                lblComponentDescription.TextColor = Colors.Black;
                lblComponentDescription.Margin = new Thickness(20, 0, 0, 0);
                lblComponentDescription.GestureRecognizers.Add(tap);

                MenuContainer.Children.Add(lblComponentTitle);
                MenuContainer.Children.Add(lblComponentDescription);
            }
        }
    }

    private void OnTapComponent(Object sender, EventArgs e)
    {
        var label = (Label)sender;
        var tap = (TapGestureRecognizer)label.GestureRecognizers[0];
        var page = (Type)tap.CommandParameter;

        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(page));
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }

    private void OnTapInicio(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new AppMauiGallery.Views.MainPage());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }
}