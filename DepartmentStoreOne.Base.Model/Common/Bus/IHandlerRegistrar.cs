using System;
using System.Threading;
using System.Threading.Tasks;
using Department.Base.Model.Common.Messages;

namespace Department.Base.Model.Common.Bus
{
    public interface IHandlerRegistrar
    {
        void RegisterHandler<T>(Func<T, CancellationToken,Task> handler) where T : class, IMessage;
    }
}
