using AppMauiGallery.Models;
using AppMauiGallery.Views.Components.Mains;
using AppMauiGallery.Views.Components.Visuals;
using AppMauiGallery.Views.Layouts;

namespace AppMauiGallery.Repositories;

internal class CategoryRepository
{
    public CategoryRepository() { }
    
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

        categories.Add(new Category
        {
            Name = "Componentes (Views)",
            Components = new List<Component>
            {
                new Component
                {
                    Title = "BoxView",
                    Description = "Um elemento que cria uma caixa para ser apresentada",
                    Page = typeof(BoxViewPage)
                },
                new Component
                {
                    Title = "Label",
                    Description = "Apresenta o texto na tela",
                    Page = typeof(LabelPage)
                },
                new Component
                {
                    Title = "Button",
                    Description = "Apresenta um botão na tela.",
                    Page = typeof(ButtonPage)
                },
                new Component
                {
                    Title = "Image",
                    Description = "Apresenta uma Imagem na tela.",
                    Page = typeof(ImagePage)
                },
                new Component
                {
                    Title = "ImageButton",
                    Description = "Apresenta uma Imagem com comportamento de botão.",
                    Page = typeof(ImageButtonPage)
                },
            }
        });

        categories.Add(new Category
        {
            Name = "Visuais",
            Components = new List<Component> { 
                new Component
                {
                    Title = "Frame",
                    Description = "Caixa que envolve outros elementos",
                    Page = typeof(FramePage)
                },
                new Component
                {
                    Title = "Border",
                    Description = "Caixa que envolve outros elementos",
                    Page = typeof(BorderPage)
                },
            }
        });

        return categories;
    }
}
