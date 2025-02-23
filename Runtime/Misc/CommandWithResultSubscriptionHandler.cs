using System;
using ED.EventBus.Signals;

namespace ED.EventBus.Misc
{
    public readonly struct CommandWithResultSubscriptionHandler<TResult> : IDisposable
    {
        private readonly CommandWithResult<TResult> _command;
        
        internal CommandWithResultSubscriptionHandler(CommandWithResult<TResult> command)
        {
            _command = command;
        }
        
        public void Dispose()
        {
            _command.RemoveListener();
        }
    }
    
    public readonly struct CommandWithResultSubscriptionHandler<T, TResult> : IDisposable
    {
        private readonly CommandWithResult<T, TResult> _command;
        
        internal CommandWithResultSubscriptionHandler(CommandWithResult<T, TResult> command)
        {
            _command = command;
        }
        
        public void Dispose()
        {
            _command.RemoveListener();
        }
    }
    
    public readonly struct CommandWithResultSubscriptionHandler<T1, T2, TResult> : IDisposable
    {
        private readonly CommandWithResult<T1, T2, TResult> _command;
        
        internal CommandWithResultSubscriptionHandler(CommandWithResult<T1, T2, TResult> command)
        {
            _command = command;
        }
        
        public void Dispose()
        {
            _command.RemoveListener();
        }
    }
    
    public readonly struct CommandWithResultSubscriptionHandler<T1, T2, T3, TResult> : IDisposable
    {
        private readonly CommandWithResult<T1, T2, T3, TResult> _command;
        
        internal CommandWithResultSubscriptionHandler(CommandWithResult<T1, T2, T3, TResult> command)
        {
            _command = command;
        }
        
        public void Dispose()
        {
            _command.RemoveListener();
        }
    }
    
    public readonly struct CommandWithResultSubscriptionHandler<T1, T2, T3, T4, TResult> : IDisposable
    {
        private readonly CommandWithResult<T1, T2, T3, T4, TResult> _command;
        
        internal CommandWithResultSubscriptionHandler(CommandWithResult<T1, T2, T3, T4, TResult> command)
        {
            _command = command;
        }
        
        public void Dispose()
        {
            _command.RemoveListener();
        }
    }
}