using System.Collections.Generic;

namespace Department.Base.Model.Common
{
    public abstract class Entity : ValueObject, IEntity
    {
        public virtual string Id { get; set; }

        public bool IsTransient()
        {
            return Id == null;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Id;
        }

    }
}
