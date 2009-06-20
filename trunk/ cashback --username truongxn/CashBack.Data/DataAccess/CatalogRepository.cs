using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashBack.Data
{
    public class CatalogRepository : ICatalogRepository
    {
        private CashBackDBEntities db = new CashBackDBEntities();

        public IEnumerable<Category> GetAllCategories()
        {
            int activeCode = StatusEnum.Active.GetHashCode();

            var categories = (from c in db.CategorySet
                              where c.Status == activeCode && c.ParentID.HasValue == false
                              select c).ToList();

            return categories;
        }
    }
}
