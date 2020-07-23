using System.Threading;
using System.Threading.Tasks;

namespace Department.Base.Model.Common.Messages
{
    public interface ICancellableHandler<in T> where T : IMessage
    {
        Task Handle(T message, CancellationToken token = default(CancellationToken));
    }
}