using Department.Base.Model.Common.Events;

namespace Department.Base.Model.Security.Events
{
    public class UserDeletedEvent : DomainEvent
    {
        public UserDeletedEvent(WorkContext workContext, User user)
        {
            WorkContext = workContext;
            User = user;
        }

        public WorkContext WorkContext { get; set; }
        public User User { get; set; }
    }
}
