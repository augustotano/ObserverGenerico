using System;

namespace Observer
{
    public interface IObserver
    {
        void Update(IObject obj);
    }
}