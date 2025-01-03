using System;
using ED.EventBus.Signals;

namespace ED.EventBus.Misc
{
    public readonly struct SignalSubscriptionHandler : IDisposable
    {
        private readonly Signal _signal;
        private readonly Action _handler;
        
        internal SignalSubscriptionHandler(Signal signal, Action handler)
        {
            _signal = signal;
            _handler = handler;
        }
        
        public void Dispose()
        {
            _signal.RemoveListener(_handler);
        }
    }
    
    public readonly struct SignalSubscriptionHandler<T> : IDisposable
    {
        private readonly Signal<T> _signal;
        private readonly Action<T> _handler;
        
        internal SignalSubscriptionHandler(Signal<T> signal, Action<T> handler)
        {
            _signal = signal;
            _handler = handler;
        }
        
        public void Dispose()
        {
            _signal.RemoveListener(_handler);
        }
    }
    
    public readonly struct SignalSubscriptionHandler<T1, T2> : IDisposable
    {
        private readonly Signal<T1, T2> _signal;
        private readonly Action<T1, T2> _handler;
        
        internal SignalSubscriptionHandler(Signal<T1, T2> signal, Action<T1, T2> handler)
        {
            _signal = signal;
            _handler = handler;
        }
        
        public void Dispose()
        {
            _signal.RemoveListener(_handler);
        }
    }
    
    public readonly struct SignalSubscriptionHandler<T1, T2, T3> : IDisposable
    {
        private readonly Signal<T1, T2, T3> _signal;
        private readonly Action<T1, T2, T3> _handler;
        
        internal SignalSubscriptionHandler(Signal<T1, T2, T3> signal, Action<T1, T2, T3> handler)
        {
            _signal = signal;
            _handler = handler;
        }
        
        public void Dispose()
        {
            _signal.RemoveListener(_handler);
        }
    }
    
    public readonly struct SignalSubscriptionHandler<T1, T2, T3, T4> : IDisposable
    {
        private readonly Signal<T1, T2, T3, T4> _signal;
        private readonly Action<T1, T2, T3, T4> _handler;
        
        internal SignalSubscriptionHandler(Signal<T1, T2, T3, T4> signal, Action<T1, T2, T3, T4> handler)
        {
            _signal = signal;
            _handler = handler;
        }
        
        public void Dispose()
        {
            _signal.RemoveListener(_handler);
        }
    }
}