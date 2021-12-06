using ShopApp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.data.Abstract
{
    public interface ICategoryRepository: IRepository<Category>
    {
        List<Category> GetPopularCategories();
    }
}
