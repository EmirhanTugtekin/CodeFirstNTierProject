using DAL_Layer.Concrete;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DAL_Layer
{
    public interface IProductDal:IGenericDal<Product>
    {
        //List<Product> GetListWithCategory();
    }
}
