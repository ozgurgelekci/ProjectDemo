using System.Web.Http.Dependencies;
using Ninject;

namespace Demo.IoC.Ninject
{
    public class ApiDependencyResolver : NinjectDependencyScope, IDependencyResolver
    {
        private readonly IKernel _kernel;

        public ApiDependencyResolver(IKernel kernel)
        : base(kernel)
        {
            _kernel = kernel;
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectDependencyScope(_kernel.BeginBlock());
        }
    }
}
