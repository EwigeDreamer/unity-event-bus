using System;
using ED.EventBus.Signals;

namespace ED.EventBus.Misc
{
    public readonly struct CommandSubscriptionHandler : IDisposable
    {
        private readonly Command _command;
        private readonly Action _handler;
        
        internal CommandSubscriptionHandler(Command command, Action handler)
        {
            _command = command;
            _handler = handler;
        }
        
        public void Dispose()
        {
            _command.RemoveListener(_handler);
        }
    }
    
    public readonly struct CommandSubscriptionHandler<T> : IDisposable
    {
        private readonly Command<T> _command;
        private readonly Action<T> _handler;
        
        internal CommandSubscriptionHandler(Command<T> command, Action<T> handler)
        {
            _command = command;
            _handler = handler;
        }
        
        public void Dispose()
        {
            _command.RemoveListener(_handler);
        }
    }
    
    public readonly struct CommandSubscriptionHandler<T1, T2> : IDisposable
    {
        private readonly Command<T1, T2> _command;
        private readonly Action<T1, T2> _handler;
        
        internal CommandSubscriptionHandler(Command<T1, T2> command, Action<T1, T2> handler)
        {
            _command = command;
            _handler = handler;
        }
        
        public void Dispose()
        {
            _command.RemoveListener(_handler);
        }
    }
    
    public readonly struct CommandSubscriptionHandler<T1, T2, T3> : IDisposable
    {
        private readonly Command<T1, T2, T3> _command;
        private readonly Action<T1, T2, T3> _handler;
        
        internal CommandSubscriptionHandler(Command<T1, T2, T3> command, Action<T1, T2, T3> handler)
        {
            _command = command;
            _handler = handler;
        }
        
        public void Dispose()
        {
            _command.RemoveListener(_handler);
        }
    }
    
    public readonly struct CommandSubscriptionHandler<T1, T2, T3, T4> : IDisposable
    {
        private readonly Command<T1, T2, T3, T4> _command;
        private readonly Action<T1, T2, T3, T4> _handler;
        
        internal CommandSubscriptionHandler(Command<T1, T2, T3, T4> command, Action<T1, T2, T3, T4> handler)
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