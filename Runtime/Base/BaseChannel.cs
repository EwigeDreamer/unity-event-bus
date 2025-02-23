using System;
using System.Collections.Generic;

namespace ED.EventBus.Base
{
    public abstract class BaseChannel
    {
        private readonly Dictionary<Type, BaseSignal> _signals = new();
        private readonly Dictionary<Type, BaseCommand> _commands = new();
        private readonly Dictionary<Type, BaseRequest> _requests = new();

        public T GetSignal<T>() where T : BaseSignal, new()
        {
            if (typeof(T).DeclaringType != GetType())
                throw new InvalidOperationException($"Signal '{typeof(T).Name}' is not nested in Channel '{GetType().Name}'");
            
            if (_signals.TryGetValue(typeof(T), out var signal)) return (T)signal;
            return (T)(_signals[typeof(T)] = new T());
        }

        public T GetCommand<T>() where T : BaseCommand, new()
        {
            if (typeof(T).DeclaringType != GetType())
                throw new InvalidOperationException($"Command '{typeof(T).Name}' is not nested in Channel '{GetType().Name}'");
            
            if (_commands.TryGetValue(typeof(T), out var command)) return (T)command;
            return (T)(_commands[typeof(T)] = new T());
        }

        public T GetRequest<T>() where T : BaseRequest, new()
        {
            if (typeof(T).DeclaringType != GetType())
                throw new InvalidOperationException($"Request '{typeof(T).Name}' is not nested in Channel '{GetType().Name}'");
            
            if (_requests.TryGetValue(typeof(T), out var command)) return (T)command;
            return (T)(_requests[typeof(T)] = new T());
        }

        internal void Dispose()
        {
            foreach (var signal in _signals.Values) signal.Dispose();
            foreach (var command in _commands.Values) command.Dispose();
            foreach (var request in _requests.Values) request.Dispose();
            _signals.Clear();
            _commands.Clear();
            _requests.Clear();
        }
    }
}