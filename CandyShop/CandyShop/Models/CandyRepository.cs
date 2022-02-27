using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class CandyRepository : ICandyRepository
    {
        //inject CategoryRepository, to have access to categories properties
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();


        public IEnumerable<Candy> GetAllCandies => new List<Candy>
        {
            new Candy{CandyId=1, Name="Asorted Hard Candy", Price=2.22M, Description="Lorem ipsum dolor sit amet enim. " +
                "Etiam ullamcorper. Suspendisse a pellentesque dui, non felis", Category = _categoryRepository.GetAllCategories.ToList()[0],
                ImageUrl="https://pixabay.com/pl/photos/cukierki-%c5%82akocie-s%c5%82oik-pojemnik-1961536/", IsInStock=true, IsOnSale=false,
                ImageThumbnailUrl="https://pixabay.com/pl/photos/cukierki-%c5%82akocie-s%c5%82oik-pojemnik-1961536/"},
            new Candy{CandyId=2, Name="Super Hard Candy", Price=4.22M, Description="Lorem ipsum dolor sit amet enim. " +
                "Etiam ullamcorper. Suspendisse a pellentesque dui, non felis", Category = _categoryRepository.GetAllCategories.ToList()[0],
                ImageUrl="https://pixabay.com/pl/photos/s%c5%82odycze-serce-serca-cukierki-2087594/", IsInStock=true, IsOnSale=true,
                ImageThumbnailUrl="https://pixabay.com/pl/photos/s%c5%82odycze-serce-serca-cukierki-2087594/"},
            new Candy{CandyId=3, Name="Super Chocolate Candy", Price=3.33M, Description="Lorem ipsum dolor sit amet enim. " +
                "Etiam ullamcorper. Suspendisse a pellentesque dui, non felis", Category = _categoryRepository.GetAllCategories.ToList()[1],
                ImageUrl="https://cdn.pixabay.com/photo/2014/11/30/10/48/chocolate-551424__340.jpg", IsInStock=true, IsOnSale=true,
                ImageThumbnailUrl="https://cdn.pixabay.com/photo/2014/11/30/10/48/chocolate-551424__340.jpg"},
            new Candy{CandyId=4, Name="Dark Chocolate Candy", Price=5.55M, Description="Lorem ipsum dolor sit amet enim. " +
                "Etiam ullamcorper. Suspendisse a pellentesque dui, non felis", Category = _categoryRepository.GetAllCategories.ToList()[1],
                ImageUrl="https://cdn.pixabay.com/photo/2017/04/12/16/56/chocolates-2224998__340.jpg", IsInStock=true, IsOnSale=true,
                ImageThumbnailUrl="https://cdn.pixabay.com/photo/2017/04/12/16/56/chocolates-2224998__340.jpg"},
            new Candy{CandyId=5, Name="Mango Candy", Price=5.55M, Description="Lorem ipsum dolor sit amet enim. " +
                "Etiam ullamcorper. Suspendisse a pellentesque dui, non felis", Category = _categoryRepository.GetAllCategories.ToList()[2],
                ImageUrl="https://cdn.pixabay.com/photo/2018/06/19/23/30/sugar-3485447__340.jpg", IsInStock=true, IsOnSale=true,
                ImageThumbnailUrl="https://cdn.pixabay.com/photo/2018/06/19/23/30/sugar-3485447__340.jpg"},
        };


        public IEnumerable<Candy> GetCandiesOnSale => throw new NotImplementedException();

        public Candy GetCandyById(int candyId)
        {
            return GetAllCandies.FirstOrDefault(c => c.CandyId == candyId);
        }
    }
}
