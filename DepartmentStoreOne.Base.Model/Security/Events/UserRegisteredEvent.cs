using Department.Base.Model.Common.Events;

namespace Department.Base.Model.Security.Events
{
    public class UserRegisteredEvent : DomainEvent
    {
        public UserRegisteredEvent(WorkContext workContext, User user, UserRegistration registration)
        {
            WorkContext = workContext;
            User = user;
            UserRegistration = registration;
        }

        public WorkContext WorkContext { get; set; }
        public User User { get; set; }
        public UserRegistration UserRegistration { get; set; }
    }
}
