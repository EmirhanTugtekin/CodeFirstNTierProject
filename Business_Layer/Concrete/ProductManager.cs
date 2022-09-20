using Business_Layer.Abstract;
using DAL_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TDelete(Product item)
        {
            _productDal.Delete(item);
        }

        public Product TGetById(int id)
        {
            return _productDal.GetByID(id);
        }

        public List<Product> TGetList()
        {
            return _productDal.GetList();
        }

        public void TInsert(Product item)
        {
            if (item.ProductName.Length <= 5 && item.ProductName.Length >= 20)
            {
                //hata mesajı 
            }
            else
            {
                _productDal.Insert(item);
            }
        }

        public void TUpdate(Product item)
        {
            _productDal.Update(item);
        }
    }
}
