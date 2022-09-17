using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Layer
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        void ChangeStatusToTrue(int id);
    }
}
