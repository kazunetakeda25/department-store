using Department.Base.Model.Common;
using Department.Base.Model.Common.Specifications;

namespace Department.Base.Model.Marketing
{
    public class HtmlDynamicContentSpecification : ISpecification<DynamicContentItem>, ISpecification<DynamicProperty>
    {
        public bool IsSatisfiedBy(DynamicContentItem contentItem)
        {
            return !string.IsNullOrEmpty(contentItem.ContentType) && contentItem.ContentType.EqualsInvariant("Html");        
        }

        public bool IsSatisfiedBy(DynamicProperty dynamicPropety)
        {
            return !string.IsNullOrEmpty(dynamicPropety.Name) && dynamicPropety.Name.EqualsInvariant("Html");
        }
    }
}
