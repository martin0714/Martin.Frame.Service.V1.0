using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame.ServiceContainer
{
    public interface IContainer
    {
        void InitContainer();
        void Register<TClass, TInterface>(TClass tClass) where TClass : class, TInterface;
        TInterface Resolve<TInterface>();
        bool TryResolve<TInterface>(out TInterface tInterface);
    }
}
