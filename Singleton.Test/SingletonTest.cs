using Singleton.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Test
{
    public class SingletonTest
    {
        [Fact]
        public void Create_should_always_return_the_same_instance()
        {
            var first = SingletonWithLock.Create();
            var second = SingletonWithLock.Create();
            Assert.Same(first, second);
        }
    }
}
