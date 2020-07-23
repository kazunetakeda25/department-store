
using Department.Base.Model.Common.Messages;

namespace Department.Base.Model.Common.Events
{
    public interface IEventHandler<in T> : IHandler<T> where T : IEvent
    {
    }
}
