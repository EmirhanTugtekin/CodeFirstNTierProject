using DAL_Layer.Concrete;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DAL_Layer
{
    public class EfProductDal : GenericRepo<Product>, IProductDal
    {
        /*public List<Product> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Products.Include(x => x.Category).ToList();
            }

        }*/

    }
}
