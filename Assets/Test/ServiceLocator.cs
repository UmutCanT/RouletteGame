using System.Collections.Generic;
using System;

namespace Test
{
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, object> services = new();

        public static void Register<T>(T service)
        {
            services[typeof(T)] = service;
        }

        public static T Resolve<T>()
        {
            return (T)services[typeof(T)];
        }
    }
}