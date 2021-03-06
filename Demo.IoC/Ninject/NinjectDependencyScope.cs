﻿using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Ninject;
using Ninject.Syntax;

namespace Demo.IoC.Ninject
{
    public class NinjectDependencyScope : IDependencyScope
    {
        private IResolutionRoot _resolver;

        public NinjectDependencyScope(IResolutionRoot resolver)
        {
            _resolver = resolver;
        }


        public void Dispose()
        {
            IDisposable disposable = _resolver as IDisposable;
            if (disposable != null)
            {
                disposable.Dispose();
            }
            _resolver = null;
        }

        public object GetService(Type serviceType)
        {
            if (_resolver == null)
            {
                throw new ObjectDisposedException("this", "This scope has been disposed");
            }
            return _resolver.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            if (_resolver == null)
            {
                throw new ObjectDisposedException("this", "This scope has been disposed");
            }
            return _resolver.GetAll(serviceType);
        }
    }
}
