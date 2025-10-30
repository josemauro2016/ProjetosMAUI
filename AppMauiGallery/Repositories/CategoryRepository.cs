using AppMauiGallery.Models;
using AppMauiGallery.Views.Layouts;

namespace AppMauiGallery.Repositories;

internal class CategoryRepository
{
    public CategoryRepository()
    {
      
    }
    
    public List<Category> GetCategories()
    {
        List<Category> categories = new List<Category>();
        categories.Add(new Category
        {
            Name = "Layout",
            Components = new List<Component>
            {
                new Component
                {
                    Title = "StackLayout",
                    Description = "Descrição sequencial dos elementos.",
                    Page = typeof(StackLayoutPage)
                },
                new Component
                {
                    Title = "Grid",
                    Description = "Organiza os elemento dentro de uma tabela",
                    Page = typeof(GridLayoutPage)
                },
                new Component
                {
                    Title = "AbsoluteLayout",
                    Description = "Liberdade total para posicionar e dimensionar os elementos na tela.",
                    Page = typeof(AbsolutLayoutPage)
                },
                new Component
                {
                    Title = "FlexLayout",
                    Description = "Organiza os elementos de forma sequencial e com muitas opções de personalização",
                    Page = typeof(FlexLayoutPage)
                },

            }
        });

        return categories;
    }
}
