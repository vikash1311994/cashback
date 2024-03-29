﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashBack.Data
{
    public interface ICatalogRepository
    {
        IEnumerable<Category> GetAllCategories();
        IEnumerable<Product> GetIndexProducts(DateTime lastModified);
    }
}
