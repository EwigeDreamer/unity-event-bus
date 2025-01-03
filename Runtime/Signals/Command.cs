using System;
using ED.EventBus.Base;
using ED.EventBus.Misc;

namespace ED.EventBus.Signals
{
    public abstract class Command : BaseCommand
    {
        private Action _callback;

        public CommandSubscriptionHandler AddListener(Action handler)
        {
            _callback += handler;
            return new CommandSubscriptionHandler(this, handler);
        }

        public void RemoveListener(Action handler)
        {
            _callback -= handler;
        }

        public void Call()
        {
            _callback?.Invoke();
        }
    }
    
    public abstract class Command<T> : BaseCommand
    {
        private Action<T> _callback;

        public CommandSubscriptionHandler<T> AddListener(Action<T> handler)
        {
            _callback += handler;
            return new CommandSubscriptionHandler<T>(this, handler);
        }

        public void RemoveListener(Action<T> handler)
        {
            _callback -= handler;
        }

        public void Call(T arg)
        {
            _callback?.Invoke(arg);
        }
    }
    
    public abstract class Command<T1, T2> : BaseCommand
    {
        private Action<T1, T2> _callback;

        public CommandSubscriptionHandler<T1, T2> AddListener(Action<T1, T2> handler)
        {
            _callback += handler;
            return new CommandSubscriptionHandler<T1, T2>(this, handler);
        }

        public void RemoveListener(Action<T1, T2> handler)
        {
            _callback -= handler;
        }

        public void Call(T1 arg1, T2 arg2)
        {
            _callback?.Invoke(arg1, arg2);
        }
    }
    
    public abstract class Command<T1, T2, T3> : BaseCommand
    {
        private Action<T1, T2, T3> _callback;

        public CommandSubscriptionHandler<T1, T2, T3> AddListener(Action<T1, T2, T3> handler)
        {
            _callback += handler;
            return new CommandSubscriptionHandler<T1, T2, T3>(this, handler);
        }

        public void RemoveListener(Action<T1, T2, T3> handler)
        {
            _callback -= handler;
        }

        public void Call(T1 arg1, T2 arg2, T3 arg3)
        {
            _callback?.Invoke(arg1, arg2, arg3);
        }
    }
    
    public abstract class Command<T1, T2, T3, T4> : BaseCommand
    {
        private Action<T1, T2, T3, T4> _callback;

        public CommandSubscriptionHandler<T1, T2, T3, T4> AddListener(Action<T1, T2, T3, T4> handler)
        {
            _callback += handler;
            return new CommandSubscriptionHandler<T1, T2, T3, T4>(this, handler);
        }

        public void RemoveListener(Action<T1, T2, T3, T4> handler)
        {
            _callback -= handler;
        }

        public void Call(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            _callback?.Invoke(arg1, arg2, arg3, arg4);
        }
    }
}