using AppMauiGallery.Models;
using AppMauiGallery.Views.Cells;
using AppMauiGallery.Views.Components.Forms;
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
                new Component
                {
                    Title = "Shadow",
                    Description = "Adiciona uma sombra ao elemento",
                    Page = typeof(ShadowPage)
                },
            }
        });
        categories.Add(new Category
        {
            Name = "Formulários",
            Components = new List<Component>
            {
                new Component
                {
                    Title = "Entry",
                    Description = "Cria uma caixa de entrada de texto",
                    Page= typeof(EntryPage)
                },
                new Component
                {
                    Title = "Editor",
                    Description = "Cria uma caixa de entrada de texto de multiplas linhas",
                    Page= typeof(EditorPage)
                },
                new Component
                {
                    Title = "CheckBox",
                    Description = "Cria uma caixa de marcação",
                    Page= typeof(CheckBoxPage)
                },
                new Component
                {
                    Title = "RadioButton",
                    Description = "Cria uma caixa de marcação de escolha única.",
                    Page= typeof(RadioButtonPage)
                },
                new Component
                {
                    Title = "Switch",
                    Description = "Caixa para determinar estado booleano.",
                    Page= typeof(SwitchPage)
                },
                new Component
                {
                    Title = "Stepper",
                    Description = "Incrementa ou decrementa um número.",
                    Page= typeof(StepperPage)
                },
                new Component
                {
                    Title = "Slider",
                    Description = "Barra que incrementa ou decrementa um número.",
                    Page= typeof(SliderPage)
                },
                new Component
                {
                    Title = "TimePicker",
                    Description = "Seleção das horas e dos minutos.",
                    Page= typeof(TimePickerPage)
                },
                new Component
                {
                    Title = "DatePicker",
                    Description = "Seleção de data.",
                    Page= typeof(DatePickerPage)
                },
                new Component
                {
                    Title = "SearchBar",
                    Description = "Campo de entrada de texto para pesquisa.",
                    Page= typeof(SearchBarPage)
                },
                new Component
                {
                    Title = "Picker",
                    Description = "Selecionar um item da lista.",
                    Page= typeof(PickerPage)
                },
            }
        });

        categories.Add(new Category
        {
            Name = "Celulas",
            Components = new List<Component> 
            { 
                new Component
                {
                    Title = "TextCell",
                    Description = "Apresenta até duas labels onde uma é destinada ao titulo e outra  a descrição",
                    Page= typeof(TextCellPage)
                },
            }
        });

        return categories;
    }
}
