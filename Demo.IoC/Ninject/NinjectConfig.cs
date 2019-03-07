
using Demo.Core.Entities.Concrete.Access;
using Demo.Core.Entities.Concrete.Common;
using Demo.Core.Entities.Concrete.Docs;
using Demo.Core.Entities.Concrete.Log;
using Demo.Core.Entities.Concrete.SysProj;
using Demo.Data.GenericRepository.Abstract;
using Demo.Data.GenericRepository.Concrete;
using Demo.Data.UnitOfWork.Abstract;
using Demo.Data.UnitOfWork.Concrete;
using Ninject;

namespace Demo.IoC.Ninject
{
    public static class NinjectConfig
    {
        public static IKernel CreateKernel()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InSingletonScope();

            //Schema : Access
            kernel.Bind<IGenericRepository<Permission>>().To<GenericRepository<Permission>>();
            kernel.Bind<IGenericRepository<Role>>().To<GenericRepository<Role>>();
            kernel.Bind<IGenericRepository<RolePermission>>().To<GenericRepository<RolePermission>>();
            kernel.Bind<IGenericRepository<User>>().To<GenericRepository<User>>();
            kernel.Bind<IGenericRepository<UserRole>>().To<GenericRepository<UserRole>>();

            //Schema : Common
            kernel.Bind<IGenericRepository<Person>>().To<GenericRepository<Person>>();
            kernel.Bind<IGenericRepository<Unit>>().To<GenericRepository<Unit>>();

            // Schema : Docs
            kernel.Bind<IGenericRepository<Media>>().To<GenericRepository<Media>>();

            // Schema : Log
            kernel.Bind<IGenericRepository<ExceptionLog>>().To<GenericRepository<ExceptionLog>>();
            kernel.Bind<IGenericRepository<RequestDetailLog>>().To<GenericRepository<RequestDetailLog>>();
            kernel.Bind<IGenericRepository<RequestLog>>().To<GenericRepository<RequestLog>>();

            // Schema : SysProj
            kernel.Bind<IGenericRepository<Language>>().To<GenericRepository<Language>>();
            kernel.Bind<IGenericRepository<Lookup>>().To<GenericRepository<Lookup>>();
            kernel.Bind<IGenericRepository<LookupList>>().To<GenericRepository<LookupList>>();
            kernel.Bind<IGenericRepository<Parameter>>().To<GenericRepository<Parameter>>();
            kernel.Bind<IGenericRepository<Resource>>().To<GenericRepository<Resource>>();

            return kernel;
        }
    }
}
