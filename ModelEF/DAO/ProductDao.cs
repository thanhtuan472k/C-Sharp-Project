using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEF.Model;

namespace ModelEF.Model
{
    public class ProductDao
    {
        NgoThanhTuanContext db = null;

        public ProductDao()
        {
            db = new NgoThanhTuanContext();
        }

        public List<Product> ListNewProduct(int top)
        {
            return db.SanPhams.OrderByDescending(x => x.UnitCost).Take(top).ToList();
        }

   
    }
}
