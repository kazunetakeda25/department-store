using Department.Base.Model.Common.Events;
using Department.Base.Model.Customer;

namespace Department.Base.Model.Security.Events
{
    /// <summary>
    /// Event generated when user logged in to the Base
    /// </summary>
    public partial class UserLoginEvent : DomainEvent
    {
        public UserLoginEvent(WorkContext workContext, User user)
        {
            WorkContext = workContext;
            User = user;
        }

        public WorkContext WorkContext { get; set; }
        public User User { get; set; }
    }
}
