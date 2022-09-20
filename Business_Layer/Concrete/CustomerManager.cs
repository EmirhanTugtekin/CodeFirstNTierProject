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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer item)
        {
            //silme işlemi için yetkin var mı
            _customerDal.Delete(item);
        }

        public Customer TGetByID(int id)
        {
            return _customerDal.GetByID(id);
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetByID(id);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
        }

        public void TInsert(Customer item)
        {
            if (item.CustomerSurname.Length <= 5 && item.CustomerName.Length <= 5 && item.CustomerName.Length >= 20)
            {
                //hata mesajı 
            }
            else
            {
                item.CustomerRole = "C";
                _customerDal.Insert(item);
            }
        }

        public void TUpdate(Customer item)
        {
            _customerDal.Update(item);
        }
    }
}
