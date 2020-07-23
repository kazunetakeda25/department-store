using System;
using Department.Base.Model.Common.Messages;

namespace Department.Base.Model.Common.Events
{
    public interface IEvent : IMessage
    {
        Guid Id { get; set; }
        int Version { get; set; }
        DateTimeOffset TimeStamp { get; set; }
    }
}
