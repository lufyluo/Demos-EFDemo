using Autofac;

namespace Demo.Framework.DynamicInject
{
    /// <summary>
    /// Lind框架对象容器
    /// </summary>
    public class LindContainer
    {
        /// <summary>
        /// 容器的生产者
        /// </summary>
        public static ContainerBuilder Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                            instance = new ContainerBuilder();
                    }
                }
                return instance;
            }
        }
        /// <summary>
        ///容器的消费者
        /// </summary>
        public static IContainer Container
        {
            get
            {
                if (container == null)
                {
                    lock (lockObj)
                    {
                        if (container == null)
                            container = instance.Build();
                    }
                }
                return container;
            }
        }
        static IContainer container;
        static ContainerBuilder instance;
        static object lockObj = new object();

    }
}
