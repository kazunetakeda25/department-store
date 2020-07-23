using Department.Base.Model.Common.Messages;

namespace Department.Base.Model.Common.Events
{
    public interface ICancellableEventHandler<in T> : ICancellableHandler<T> where T : IEvent
    {
    }
}