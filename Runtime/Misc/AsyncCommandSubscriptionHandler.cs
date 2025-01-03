#if EVENTBUS_UNITASK_SUPPORT

using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using ED.EventBus.Signals;

namespace ED.EventBus.Misc
{
    public readonly struct AsyncCommandSubscriptionHandler : IDisposable
    {
        private readonly AsyncCommand _command;
        private readonly Func<CancellationToken, UniTask> _handler;
        
        internal AsyncCommandSubscriptionHandler(AsyncCommand command, Func<CancellationToken, UniTask> handler)
        {
            _command = command;
            _handler = handler;
        }
        
        public void Dispose()
        {
            _command.RemoveListener(_handler);
        }
    }
    
    public readonly struct AsyncCommandSubscriptionHandler<T> : IDisposable
    {
        private readonly AsyncCommand<T> _command;
        private readonly Func<T, CancellationToken, UniTask> _handler;
        
        internal AsyncCommandSubscriptionHandler(AsyncCommand<T> command, Func<T, CancellationToken, UniTask> handler)
        {
            _command = command;
            _handler = handler;
        }
        
        public void Dispose()
        {
            _command.RemoveListener(_handler);
        }
    }
    
    public readonly struct AsyncCommandSubscriptionHandler<T1, T2> : IDisposable
    {
        private readonly AsyncCommand<T1, T2> _command;
        private readonly Func<T1, T2, CancellationToken, UniTask> _handler;
        
        internal AsyncCommandSubscriptionHandler(AsyncCommand<T1, T2> command, Func<T1, T2, CancellationToken, UniTask> handler)
        {
            _command = command;
            _handler = handler;
        }
        
        public void Dispose()
        {
            _command.RemoveListener(_handler);
        }
    }
    
    public readonly struct AsyncCommandSubscriptionHandler<T1, T2, T3> : IDisposable
    {
        private readonly AsyncCommand<T1, T2, T3> _command;
        private readonly Func<T1, T2, T3, CancellationToken, UniTask> _handler;
        
        internal AsyncCommandSubscriptionHandler(AsyncCommand<T1, T2, T3> command, Func<T1, T2, T3, CancellationToken, UniTask> handler)
        {
            _command = command;
            _handler = handler;
        }
        
        public void Dispose()
        {
            _command.RemoveListener(_handler);
        }
    }
    
    public readonly struct AsyncCommandSubscriptionHandler<T1, T2, T3, T4> : IDisposable
    {
        private readonly AsyncCommand<T1, T2, T3, T4> _command;
        private readonly Func<T1, T2, T3, T4, CancellationToken, UniTask> _handler;
        
        internal AsyncCommandSubscriptionHandler(AsyncCommand<T1, T2, T3, T4> command, Func<T1, T2, T3, T4, CancellationToken, UniTask> handler)
        {
            _command = command;
            _handler = handler;
        }
        
        public void Dispose()
        {
            _command.RemoveListener(_handler);
        }
    }
}

#endif