using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Layer
{
    public class EfCategoryDal : GenericRepo<Category>, ICategoryDal
    {
        public void ChangeStatusToTrue(int id)
        {
            throw new NotImplementedException();
        }
    }
}
