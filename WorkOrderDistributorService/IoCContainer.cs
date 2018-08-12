using DistributorService.Core;
using Unity;

namespace WorkOrderDistributorService
{
    internal class IoCContainer
    {
        private static IUnityContainer _container;
        static object sync = new object();

        public static IUnityContainer Container
        {
            get
            {
                lock (sync)
                {
                    if (_container == null)
                    {
                        _container = new UnityContainer();
                        _container.RegisterType<IWorkOrderManager, WorkOrderManager>();
                    }
                }

                return _container;
            }
        }
    }
}