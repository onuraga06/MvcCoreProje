using BusinessLayer.Abstract;
using DataAcceesLayer.EntityFramework;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryServices

    {
        EfCategoryRepository ef = new EfCategoryRepository();
      
        public void CategoryAdd(Category category)
        {
            ef.Add(category);
        }

        public void CategoryDelete(Category category)
        {
            ef.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            ef.Update(category);
        }

        public Category GetByID(int id)
        {
            return ef.GetByID(id);
        }

        public List<Category> GetList()
        {
            return ef.GetList();
        }
    }
}
