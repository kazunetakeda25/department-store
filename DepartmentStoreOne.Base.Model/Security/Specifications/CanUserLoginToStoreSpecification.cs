using System;
using System.Linq;
using Department.Base.Model.Common;
using Department.Base.Model.Common.Specifications;
using Department.Base.Model.Stores;

namespace Department.Base.Model.Security.Specifications
{
    public class CanUserLoginToStoreSpecification : ISpecification<Store>
    {
        private readonly User _user;
        public CanUserLoginToStoreSpecification(User user)
        {
            _user = user;
        }
        public virtual bool IsSatisfiedBy(Store obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            //Allow to login to store for administrators or for users not assigned to store
            var result = _user.IsAdministrator || _user.StoreId.IsNullOrEmpty();
            if(!result)
            {   
                result = obj.TrustedGroups.Concat(new[] { obj.Id } ).Contains(_user.StoreId);
            }
            return result;
        }

    }
}
