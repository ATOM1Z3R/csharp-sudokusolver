using Autofac;
using BackTrackClassLibrary;
using BackTrackInterfacesLibrary;

namespace backtrack
{
    public static class ContainerConfig
    {
        public static IContainer Config()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<CheckLocation>().As<ICheckLocation>();
            containerBuilder.RegisterType<FindFreeSpace>().As<IFindSpace>();
            containerBuilder.RegisterType<CheckIfValueRepeating>().As<IValueRepeat>();
            containerBuilder.RegisterType<ClearFields>().As<IClearFields>();
            containerBuilder.RegisterType<FindSolution>().As<IFindSolution>();
            containerBuilder.RegisterType<AppStart>().As<IAppStart>();

            return containerBuilder.Build();
        }
    }
}
