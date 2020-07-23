using DepartmentStoreOne.Base.Model.Common;

namespace DepartmentStoreOne.Base.Model
{
    public class FormError : ValueObject, IAccessibleByIndexKey
    {
        public string Code { get; set; }
        public string Message => Description;
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
        public string IndexKey => Code;
    }
}
