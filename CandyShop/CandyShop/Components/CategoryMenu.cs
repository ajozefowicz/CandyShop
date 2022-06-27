using CandyShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Components
{
   // [ViewComponent(Name = "Dupa")]
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        //this is the view component so we need Invoke method

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.GetAllCategories.OrderBy(c => c.CategoryName);

            return View(categories);
        }


    }
}
