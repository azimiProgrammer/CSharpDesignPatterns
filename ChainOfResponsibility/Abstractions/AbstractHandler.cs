namespace ChainOfResponsibility.Abstractions
{
    public abstract class AbstractHandler<T> : IHandler<T>
    {
        private IHandler<T> _nextHandler;

        public IHandler<T> SetNext(IHandler<T> handler)
        {
            _nextHandler = handler;
            
            return handler;
        }

        public virtual T Handle(T obj)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(obj);
            }
            else
            {
                return default;
            }
        }
    }
}
