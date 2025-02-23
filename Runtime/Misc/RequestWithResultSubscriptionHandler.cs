using System;
using ED.EventBus.Signals;

namespace ED.EventBus.Misc
{
    public readonly struct RequestWithResultSubscriptionHandler<TResult> : IDisposable
    {
        private readonly RequestWithResult<TResult> _request;
        
        internal RequestWithResultSubscriptionHandler(RequestWithResult<TResult> request)
        {
            _request = request;
        }
        
        public void Dispose()
        {
            _request.RemoveListener();
        }
    }
    
    public readonly struct RequestWithResultSubscriptionHandler<T, TResult> : IDisposable
    {
        private readonly RequestWithResult<T, TResult> _request;
        
        internal RequestWithResultSubscriptionHandler(RequestWithResult<T, TResult> request)
        {
            _request = request;
        }
        
        public void Dispose()
        {
            _request.RemoveListener();
        }
    }
    
    public readonly struct RequestWithResultSubscriptionHandler<T1, T2, TResult> : IDisposable
    {
        private readonly RequestWithResult<T1, T2, TResult> _request;
        
        internal RequestWithResultSubscriptionHandler(RequestWithResult<T1, T2, TResult> request)
        {
            _request = request;
        }
        
        public void Dispose()
        {
            _request.RemoveListener();
        }
    }
    
    public readonly struct RequestWithResultSubscriptionHandler<T1, T2, T3, TResult> : IDisposable
    {
        private readonly RequestWithResult<T1, T2, T3, TResult> _request;
        
        internal RequestWithResultSubscriptionHandler(RequestWithResult<T1, T2, T3, TResult> request)
        {
            _request = request;
        }
        
        public void Dispose()
        {
            _request.RemoveListener();
        }
    }
    
    public readonly struct RequestWithResultSubscriptionHandler<T1, T2, T3, T4, TResult> : IDisposable
    {
        private readonly RequestWithResult<T1, T2, T3, T4, TResult> _request;
        
        internal RequestWithResultSubscriptionHandler(RequestWithResult<T1, T2, T3, T4, TResult> request)
        {
            _request = request;
        }
        
        public void Dispose()
        {
            _request.RemoveListener();
        }
    }
}