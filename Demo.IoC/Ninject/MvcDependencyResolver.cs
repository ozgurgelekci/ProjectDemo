using System.Web.Http.Dependencies;
using Ninject;
using IDependencyResolver = System.Web.Mvc.IDependencyResolver;

namespace Demo.IoC.Ninject
{
    public class MvcDependencyResolver : NinjectDependencyScope, IDependencyResolver
    {
        private readonly IKernel _kernel;

        public MvcDependencyResolver(IKernel kernel)
        :base(kernel)
        {
            _kernel = kernel;
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectDependencyScope(_kernel.BeginBlock());
        }
    }
}
