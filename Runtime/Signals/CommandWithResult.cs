using System;
using ED.EventBus.Base;
using ED.EventBus.Misc;

namespace ED.EventBus.Signals
{
    public abstract class CommandWithResult<TResult> : BaseCommand
    {
        private Func<TResult> _callback;

        public CommandWithResultSubscriptionHandler<TResult> SetListener(Func<TResult> callback)
        {
            _callback = callback;
            return new CommandWithResultSubscriptionHandler<TResult>(this);
        }

        public void RemoveListener()
        {
            _callback = null;
        }

        public TResult Call()
        {
            return _callback != null ? _callback() : default;
        }

        internal override void Dispose()
        {
            _callback = null;
        }
    }
    
    public abstract class CommandWithResult<T, TResult> : BaseCommand
    {
        private Func<T, TResult> _callback;

        public CommandWithResultSubscriptionHandler<T, TResult> SetListener(Func<T, TResult> callback)
        {
            _callback = callback;
            return new CommandWithResultSubscriptionHandler<T, TResult>(this);
        }

        public void RemoveListener()
        {
            _callback = null;
        }

        public TResult Call(T arg)
        {
            return _callback != null ? _callback(arg) : default;
        }

        internal override void Dispose()
        {
            _callback = null;
        }
    }
    
    public abstract class CommandWithResult<T1, T2, TResult> : BaseCommand
    {
        private Func<T1, T2, TResult> _callback;

        public CommandWithResultSubscriptionHandler<T1, T2, TResult> SetListener(Func<T1, T2, TResult> callback)
        {
            _callback = callback;
            return new CommandWithResultSubscriptionHandler<T1, T2, TResult>(this);
        }

        public void RemoveListener()
        {
            _callback = null;
        }

        public TResult Call(T1 arg1, T2 arg2)
        {
            return _callback != null ? _callback(arg1, arg2) : default;
        }

        internal override void Dispose()
        {
            _callback = null;
        }
    }
    
    public abstract class CommandWithResult<T1, T2, T3, TResult> : BaseCommand
    {
        private Func<T1, T2, T3, TResult> _callback;

        public CommandWithResultSubscriptionHandler<T1, T2, T3, TResult> SetListener(Func<T1, T2, T3, TResult> callback)
        {
            _callback = callback;
            return new CommandWithResultSubscriptionHandler<T1, T2, T3, TResult>(this);
        }

        public void RemoveListener()
        {
            _callback = null;
        }

        public TResult Call(T1 arg1, T2 arg2, T3 arg3)
        {
            return _callback != null ? _callback(arg1, arg2, arg3) : default;
        }

        internal override void Dispose()
        {
            _callback = null;
        }
    }
    
    public abstract class CommandWithResult<T1, T2, T3, T4, TResult> : BaseCommand
    {
        private Func<T1, T2, T3, T4, TResult> _callback;

        public CommandWithResultSubscriptionHandler<T1, T2, T3, T4, TResult> SetListener(Func<T1, T2, T3, T4, TResult> callback)
        {
            _callback = callback;
            return new CommandWithResultSubscriptionHandler<T1, T2, T3, T4, TResult>(this);
        }

        public void RemoveListener()
        {
            _callback = null;
        }

        public TResult Call(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return _callback != null ? _callback(arg1, arg2, arg3, arg4) : default;
        }

        internal override void Dispose()
        {
            _callback = null;
        }
    }
}