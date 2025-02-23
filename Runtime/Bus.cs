using System;
using System.Collections.Generic;
using ED.EventBus.Base;

namespace ED.EventBus
{
    public class Bus : IDisposable
    {
        private readonly Dictionary<Type, BaseChannel> _channels = new();

        public static readonly Bus Global = new();

        public T GetChannel<T>() where T : BaseChannel, new()
        {
            if (_channels.TryGetValue(typeof(T), out var channel)) return (T)channel;
            return (T)(_channels[typeof(T)] = new T());
        }

        public void Dispose()
        {
            foreach (var channel in _channels.Values)
                channel.Dispose();
            _channels.Clear();
        }
    }
}