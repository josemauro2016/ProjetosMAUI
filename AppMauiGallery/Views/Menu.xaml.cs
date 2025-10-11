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
                var lblComponentTitle = new Label();
                lblComponentTitle.Text = component.Title;
                lblComponentTitle.FontFamily = "OpenSansSemibold";
                lblComponentTitle.TextColor = Colors.Black;
                lblComponentTitle.Margin = new Thickness(20, 20, 0, 0);

                var lblComponentDescription = new Label();
                lblComponentDescription.Text = component.Description;
                lblComponentDescription.TextColor = Colors.Black;
                lblComponentDescription.Margin = new Thickness(20, 0, 0, 0);

                MenuContainer.Children.Add(lblComponentTitle);
                MenuContainer.Children.Add(lblComponentDescription);
            }
        }
    }
}