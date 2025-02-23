#if EVENTBUS_UNITASK_SUPPORT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Cysharp.Threading.Tasks;
using ED.EventBus.Base;
using ED.EventBus.Misc;

namespace ED.EventBus.Signals
{
    public abstract class AsyncCommand : BaseCommand
    {
        private readonly List<Func<CancellationToken, UniTask>> _handlers = new();

        public AsyncCommandSubscriptionHandler AddListener(Func<CancellationToken, UniTask> handler)
        {
            _handlers.Add(handler);
            return new AsyncCommandSubscriptionHandler(this, handler);
        }

        public void RemoveListener(Func<CancellationToken, UniTask> handler)
        {
            _handlers.Remove(handler);
        }

        public UniTask ParallelCall(CancellationToken cancellationToken = default)
        {
            var handlers = _handlers.ToList();
            var tasks = handlers.Select(handler => handler.Invoke(cancellationToken));
            return UniTask.WhenAll(tasks);
        }

        public async UniTask SequentialCall(CancellationToken cancellationToken = default)
        {
            var handlers = _handlers.ToList();
            foreach (var handler in handlers)
            {
                await handler.Invoke(cancellationToken);
                if (cancellationToken.IsCancellationRequested) break;
            }
        }

        internal override void Dispose()
        {
            _handlers.Clear();
        }
    }
    
    public abstract class AsyncCommand<T> : BaseCommand
    {
        private readonly List<Func<T, CancellationToken, UniTask>> _handlers = new();

        public AsyncCommandSubscriptionHandler<T> AddListener(Func<T, CancellationToken, UniTask> handler)
        {
            _handlers.Add(handler);
            return new AsyncCommandSubscriptionHandler<T>(this, handler);
        }

        public void RemoveListener(Func<T, CancellationToken, UniTask> handler)
        {
            _handlers.Remove(handler);
        }

        public UniTask ParallelCall(T arg, CancellationToken cancellationToken = default)
        {
            var handlers = _handlers.ToList();
            var tasks = handlers.Select(handler => handler.Invoke(arg, cancellationToken));
            return UniTask.WhenAll(tasks);
        }

        public async UniTask SequentialCall(T arg, CancellationToken cancellationToken = default)
        {
            var handlers = _handlers.ToList();
            foreach (var handler in handlers)
            {
                await handler.Invoke(arg, cancellationToken);
                if (cancellationToken.IsCancellationRequested) break;
            }
        }

        internal override void Dispose()
        {
            _handlers.Clear();
        }
    }
    
    public abstract class AsyncCommand<T1, T2> : BaseCommand
    {
        private readonly List<Func<T1, T2, CancellationToken, UniTask>> _handlers = new();

        public AsyncCommandSubscriptionHandler<T1, T2> AddListener(Func<T1, T2, CancellationToken, UniTask> handler)
        {
            _handlers.Add(handler);
            return new AsyncCommandSubscriptionHandler<T1, T2>(this, handler);
        }

        public void RemoveListener(Func<T1, T2, CancellationToken, UniTask> handler)
        {
            _handlers.Remove(handler);
        }

        public UniTask ParallelCall(T1 arg1, T2 arg2, CancellationToken cancellationToken = default)
        {
            var handlers = _handlers.ToList();
            var tasks = handlers.Select(handler => handler.Invoke(arg1, arg2, cancellationToken));
            return UniTask.WhenAll(tasks);
        }

        public async UniTask SequentialCall(T1 arg1, T2 arg2, CancellationToken cancellationToken = default)
        {
            var handlers = _handlers.ToList();
            foreach (var handler in handlers)
            {
                await handler.Invoke(arg1, arg2, cancellationToken);
                if (cancellationToken.IsCancellationRequested) break;
            }
        }

        internal override void Dispose()
        {
            _handlers.Clear();
        }
    }
    
    public abstract class AsyncCommand<T1, T2, T3> : BaseCommand
    {
        private readonly List<Func<T1, T2, T3, CancellationToken, UniTask>> _handlers = new();

        public AsyncCommandSubscriptionHandler<T1, T2, T3> AddListener(Func<T1, T2, T3, CancellationToken, UniTask> handler)
        {
            _handlers.Add(handler);
            return new AsyncCommandSubscriptionHandler<T1, T2, T3>(this, handler);
        }

        public void RemoveListener(Func<T1, T2, T3, CancellationToken, UniTask> handler)
        {
            _handlers.Remove(handler);
        }

        public UniTask ParallelCall(T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default)
        {
            var handlers = _handlers.ToList();
            var tasks = handlers.Select(handler => handler.Invoke(arg1, arg2, arg3, cancellationToken));
            return UniTask.WhenAll(tasks);
        }

        public async UniTask SequentialCall(T1 arg1, T2 arg2, T3 arg3, CancellationToken cancellationToken = default)
        {
            var handlers = _handlers.ToList();
            foreach (var handler in handlers)
            {
                await handler.Invoke(arg1, arg2, arg3, cancellationToken);
                if (cancellationToken.IsCancellationRequested) break;
            }
        }

        internal override void Dispose()
        {
            _handlers.Clear();
        }
    }
    
    public abstract class AsyncCommand<T1, T2, T3, T4> : BaseCommand
    {
        private readonly List<Func<T1, T2, T3, T4, CancellationToken, UniTask>> _handlers = new();

        public AsyncCommandSubscriptionHandler<T1, T2, T3, T4> AddListener(Func<T1, T2, T3, T4, CancellationToken, UniTask> handler)
        {
            _handlers.Add(handler);
            return new AsyncCommandSubscriptionHandler<T1, T2, T3, T4>(this, handler);
        }

        public void RemoveListener(Func<T1, T2, T3, T4, CancellationToken, UniTask> handler)
        {
            _handlers.Remove(handler);
        }

        public UniTask ParallelCall(T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default)
        {
            var handlers = _handlers.ToList();
            var tasks = handlers.Select(handler => handler.Invoke(arg1, arg2, arg3, arg4, cancellationToken));
            return UniTask.WhenAll(tasks);
        }

        public async UniTask SequentialCall(T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken cancellationToken = default)
        {
            var handlers = _handlers.ToList();
            foreach (var handler in handlers)
            {
                await handler.Invoke(arg1, arg2, arg3, arg4, cancellationToken);
                if (cancellationToken.IsCancellationRequested) break;
            }
        }

        internal override void Dispose()
        {
            _handlers.Clear();
        }
    }
}

#endif