using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Department.Base.Model.Common.Events;
using Department.Base.Model.Common.Messages;

namespace Department.Base.Model.Common.Bus
{
    public class InProcessBus : IEventPublisher, IHandlerRegistrar
    {
        private readonly Dictionary<Type, List<Func<IMessage, CancellationToken, Task>>> _routes = new Dictionary<Type, List<Func<IMessage, CancellationToken, Task>>>();

        public void RegisterHandler<T>(Func<T, CancellationToken, Task> handler) where T : class, IMessage
        {
            if (!_routes.TryGetValue(typeof(T), out var handlers))
            {
                handlers = new List<Func<IMessage, CancellationToken, Task>>();
                _routes.Add(typeof(T), handlers);
            }
            handlers.Add((message, token) => handler((T)message, token));
        }

        public async Task Publish<T>(T @event, CancellationToken cancellationToken = default(CancellationToken)) where T : class, IEvent
        {
            if (_routes.TryGetValue(@event.GetType(), out var handlers))
            {
                await Task.WhenAll(handlers.Select(handler => handler(@event, cancellationToken)));
            }
        }
    }
}
