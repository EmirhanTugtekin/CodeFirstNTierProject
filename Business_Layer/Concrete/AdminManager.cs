using DAL_Layer;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void TDelete(Admin item)
        {
            throw new NotImplementedException();
        }

        public Admin TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Admin item)
        {
            item.AdminRole = "A";
            _adminDal.Insert(item);
        }

        public void TUpdate(Admin item)
        {
            throw new NotImplementedException();
        }
    }
}
