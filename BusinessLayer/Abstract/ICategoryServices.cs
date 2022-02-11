﻿using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface ICategoryServices
    {
        void CategoryAdd(Category category);
        void CategoryUpdate(Category category);
        void CategoryDelete(Category category);
        List<Category> GetList();
        Category GetByID(int id);

    }
}
