using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public interface ICandyRepository
    {
        IEnumerable<Candy> GetAllCandies { get; }
        IEnumerable<Candy> GetCandiesOnSale { get; }
        Candy GetCandyById(int candyId);
    }
}
