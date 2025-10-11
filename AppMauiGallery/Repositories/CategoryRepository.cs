﻿using AppMauiGallery.Models;
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
                    Page = new StackLayoutPage()
                }
            }
        });

        return categories;
    }
}
