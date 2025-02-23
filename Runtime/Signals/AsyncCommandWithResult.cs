#if EVENTBUS_UNITASK_SUPPORT

using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using ED.EventBus.Base;

namespace ED.EventBus.Signals
{
    public abstract class AsyncCommandWithResult<TResult> : BaseCommand
    {
        private Func<CancellationToken, UniTask<TResult>> _callback;

        public void SetListener(Func<CancellationToken, UniTask<TResult>> callback)
        {
            _callback = callback;
        }

        public void RemoveListener()
        {
            _callback = null;
        }

        public UniTask<TResult> Call(CancellationToken cancellationToken = default)
        {
            return _callback?.Invoke(cancellationToken) ?? UniTask.FromResult(default(TResult));
        }

        internal override void Dispose()
        {
            _callback = null;
        }
    }
    
    public abstract class AsyncCommandWithResult<T, TResult> : BaseCommand
    {
        private Func<T, CancellationToken, UniTask<TResult>> _callback;

        public void SetListener(Func<T, CancellationToken, UniTask<TResult>> callback)
        {
            _callback = callback;
        }

        public void RemoveListener()
        {
            _callback = null;
        }

        public UniTask<TResult> Call(T arg, CancellationToken cancellationToken = default)
        {
            return _callback?.Invoke(arg, cancellationToken) ?? UniTask.FromResult(default(TResult));
        }

        internal override void Dispose()
        {
            _callback = null;
        }
    }
    
    public abstract class AsyncCommandWithResult<T1, T2, TResult> : BaseCommand
    {
        private Func<T1, T2, CancellationToken, UniTask<TResult>> _callback;

        public void SetListener(Func<T1, T2, CancellationToken, UniTask<TResult>> callback)
        {
            _callback = callback;
        }

        public void RemoveListener()
        {
            _callback = null;
        }

        public UniTask<TResult> Call(T1 arg1, T2 arg2, CancellationToken cancellationToken = default)
        {
            return _callback?.Invoke(arg1, arg2, cancellationToken) ?? UniTask.FromResult(default(TResult));
        }

        internal override void Dispose()
        {
            _callback = null;
        }
    }
    
    public abstract class AsyncCommandWithResult<T1, T2, T3, TResult> : BaseCommand
    {
        private Func<T1, T2, T3, CancellationToken, UniTask<TResult>> _callback;

        public void SetListener(Func<T1, T2, T3, CancellationToken, UniTask<TResult>> callback)
        {
            _callback = callback;
        }

        public void RemoveListener()
        {
            _callback = null;
        }

        public UniTask<TResult> Call(T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default)
        {
            return _callback?.Invoke(arg1, arg2, arg3, cancellationToken) ?? UniTask.FromResult(default(TResult));
        }

        internal override void Dispose()
        {
            _callback = null;
        }
    }
    
    public abstract class AsyncCommandWithResult<T1, T2, T3, T4, TResult> : BaseCommand
    {
        private Func<T1, T2, T3, T4, CancellationToken, UniTask<TResult>> _callback;

        public void SetListener(Func<T1, T2, T3, T4, CancellationToken, UniTask<TResult>> callback)
        {
            _callback = callback;
        }

        public void RemoveListener()
        {
            _callback = null;
        }

        public UniTask<TResult> Call(T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default)
        {
            return _callback?.Invoke(arg1, arg2, arg3, arg4, cancellationToken) ?? UniTask.FromResult(default(TResult));
        }

        internal override void Dispose()
        {
            _callback = null;
        }
    }
}

#endif