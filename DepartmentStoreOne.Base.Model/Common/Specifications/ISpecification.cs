using System;
using System.Collections.Generic;
using System.Text;

namespace Department.Base.Model.Common.Specifications
{
    public interface ISpecification<in T>
    {
        bool IsSatisfiedBy(T obj);   
    }
}
