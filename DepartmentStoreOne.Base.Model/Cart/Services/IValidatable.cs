using System.Collections.Generic;
using Department.Base.Model.Cart.ValidationErrors;

namespace Department.Base.Model.Cart.Services
{
    public interface IValidatable
    {
        bool IsValid { get; set; }
        IList<ValidationError> ValidationErrors { get; }
    }
}