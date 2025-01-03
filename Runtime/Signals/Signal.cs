using System;
using ED.EventBus.Base;
using ED.EventBus.Misc;

namespace ED.EventBus.Signals
{
    public abstract class Signal : BaseSignal
    {
        private Action _callback;

        public SignalSubscriptionHandler AddListener(Action handler)
        {
            _callback += handler;
            return new SignalSubscriptionHandler(this, handler);
        }

        public void RemoveListener(Action handler)
        {
            _callback -= handler;
        }

        public void Dispatch()
        {
            _callback?.Invoke();
        }
    }
    
    public abstract class Signal<T> : BaseSignal
    {
        private Action<T> _callback;

        public SignalSubscriptionHandler<T> AddListener(Action<T> handler)
        {
            _callback += handler;
            return new SignalSubscriptionHandler<T>(this, handler);
        }

        public void RemoveListener(Action<T> handler)
        {
            _callback -= handler;
        }

        public void Dispatch(T arg)
        {
            _callback?.Invoke(arg);
        }
    }
    
    public abstract class Signal<T1, T2> : BaseSignal
    {
        private Action<T1, T2> _callback;

        public SignalSubscriptionHandler<T1, T2> AddListener(Action<T1, T2> handler)
        {
            _callback += handler;
            return new SignalSubscriptionHandler<T1, T2>(this, handler);
        }

        public void RemoveListener(Action<T1, T2> handler)
        {
            _callback -= handler;
        }

        public void Dispatch(T1 arg1, T2 arg2)
        {
            _callback?.Invoke(arg1, arg2);
        }
    }
    
    public abstract class Signal<T1, T2, T3> : BaseSignal
    {
        private Action<T1, T2, T3> _callback;

        public SignalSubscriptionHandler<T1, T2, T3> AddListener(Action<T1, T2, T3> handler)
        {
            _callback += handler;
            return new SignalSubscriptionHandler<T1, T2, T3>(this, handler);
        }

        public void RemoveListener(Action<T1, T2, T3> handler)
        {
            _callback -= handler;
        }

        public void Dispatch(T1 arg1, T2 arg2, T3 arg3)
        {
            _callback?.Invoke(arg1, arg2, arg3);
        }
    }
    
    public abstract class Signal<T1, T2, T3, T4> : BaseSignal
    {
        private Action<T1, T2, T3, T4> _callback;

        public SignalSubscriptionHandler<T1, T2, T3, T4> AddListener(Action<T1, T2, T3, T4> handler)
        {
            _callback += handler;
            return new SignalSubscriptionHandler<T1, T2, T3, T4>(this, handler);
        }

        public void RemoveListener(Action<T1, T2, T3, T4> handler)
        {
            _callback -= handler;
        }

        public void Dispatch(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            _callback?.Invoke(arg1, arg2, arg3, arg4);
        }
    }
}