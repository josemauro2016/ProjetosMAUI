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
                }
            }
        });

        return categories;
    }
}
