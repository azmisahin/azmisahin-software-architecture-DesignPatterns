using System;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    public sealed class MultiThread<T>
    {
        private static volatile MultiThread<T> instance;
        private static object syncRoot = new Object();

        private MultiThread() { }

        public static MultiThread<T> Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new MultiThread<T>();
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// Sample Generic obje
        /// </summary>
        /// 
        public Guid Report(T model)
        {
            return model.GetType().GUID;
        }

    }

}
