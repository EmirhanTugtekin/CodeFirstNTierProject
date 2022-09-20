using Business_Layer;
using DAL_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void TChangeToStatusTrue(int id)
        {
            _categoryDal.ChangeStatusToTrue(id);
        }

        public void TDelete(Category item)
        {
            _categoryDal.Delete(item);
        }

        public Category TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Category TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> TGetList()
        {
            return _categoryDal.GetList();
        }

        public void TInsert(Category item)
        {
            _categoryDal.Insert(item);
        }

        public void TUpdate(Category item)
        {
            throw new NotImplementedException();
        }
    }
}
