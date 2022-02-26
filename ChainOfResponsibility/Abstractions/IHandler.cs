using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Abstractions
{
    public interface IHandler<T>
    {
        IHandler<T> SetNext(IHandler<T> handler);
        T Handle(T obj);
    }
}
