using Department.Base.Model.Common;

namespace Department.Base.Model.Catalog
{
    public partial class Term : ValueObject
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
