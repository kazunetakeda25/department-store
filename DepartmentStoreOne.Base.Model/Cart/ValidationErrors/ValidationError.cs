using Department.Base.Model.Common;

namespace Department.Base.Model.Cart.ValidationErrors
{
    public abstract class ValidationError : ValueObject
    {
        public ValidationError()
        {
            ErrorCode = GetType().Name;
        }

        public string ErrorCode { get; private set; }
    }
}
