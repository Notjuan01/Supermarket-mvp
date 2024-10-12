using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface ICategoriesRepository 
    {
        void Add(CategoriesModel category);
        void Edit(CategoriesModel category);
        void Delete(int id);
        IEnumerable<CategoriesModel> GetAll();
        IEnumerable<CategoriesModel> GetByValue(string id);
    }
}
