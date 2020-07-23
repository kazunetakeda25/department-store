using DepartmentStoreOne.Base.Model.Common;

namespace DepartmentStoreOne.Base.Model
{
    public partial class EditorialReview : LocalizedString, IAccessibleByIndexKey
    {
        public string ReviewType { get; set; }
        public string Content => Value;

        public string IndexKey => ReviewType;
    }
}
