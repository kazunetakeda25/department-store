using Department.Base.Model.Common.Specifications;

namespace Department.Base.Model.Security.Specifications
{
    public class IsUserSuspendedSpecification: ISpecification<User>
    {
        public bool IsSatisfiedBy(User obj)
        {
            return obj.UserState == AccountState.Rejected;
        }
    }
}
