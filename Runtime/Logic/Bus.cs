using System;
using System.Collections.Generic;
using ED.EventBus.Base;

namespace ED.EventBus
{
    public static class Bus
    {
        private static readonly Dictionary<Type, BaseChannel> _channels = new();

        public static T GetChannel<T>() where T : BaseChannel, new()
        {
            if (_channels.TryGetValue(typeof(T), out var channel)) return (T)channel;
            return (T)(_channels[typeof(T)] = new T());
        }
    }
}