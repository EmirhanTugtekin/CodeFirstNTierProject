using Business_Layer.Abstract;
using Business_Layer.Concrete;
using DAL_Layer;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using Business_Layer;
using DAL_Layer.Concrete;
using DAL_Layer.Concrete.EntityFramework;

namespace UI_Layer
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddAllBindings();
        }

        public void AddAllBindings()
        {
            this.ninjectKernel.Bind<IProductService>().To<ProductManager>().WithConstructorArgument("productDal", new EfProductDal());
            this.ninjectKernel.Bind<IProductDal>().To<EfProductDal>();
            
            this.ninjectKernel.Bind<ICategoryService>().To<CategoryManager>().WithConstructorArgument("categoryDal", new EfCategoryDal());
            this.ninjectKernel.Bind<ICategoryDal>().To<EfCategoryDal>();

            this.ninjectKernel.Bind<ICustomerService>().To<CustomerManager>().WithConstructorArgument("customerDal", new EfCustomerDal());
            this.ninjectKernel.Bind<ICustomerDal>().To<EfCustomerDal>();

            this.ninjectKernel.Bind<IAdminService>().To<AdminManager>().WithConstructorArgument("adminDal", new EfAdminDal());
            this.ninjectKernel.Bind<IAdminDal>().To<EfAdminDal>();


        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            /*if (controllerType == null)
            {
                return null;
            }
            else
            {
                return (IController)ninjectKernel.Get(controllerType);
            }*/
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }
    }
}
