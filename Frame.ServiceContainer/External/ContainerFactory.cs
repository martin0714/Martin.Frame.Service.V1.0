
using Frame.ServiceContainer.Impl;

namespace Frame.ServiceContainer.External
{
    public class ContainerFactory
    {
        private static IContainer _container;

        public static IContainer GetContainer()
        {
            if (_container == null)
            {
                _container = new ContainerImpl();
            }
            return _container;
        }

    }
}
