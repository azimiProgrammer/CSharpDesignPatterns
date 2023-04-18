using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.App
{
    public class SingletonWithLock
    {
        private readonly static object _myLock = new();

        private static SingletonWithLock? _instance;
        private SingletonWithLock() { }
        public static SingletonWithLock Create()
        {
            lock (_myLock)
            {
                if (_instance == default)
                {
                    _instance = new SingletonWithLock();
                }
            }
            return _instance;
        }
    }
}
