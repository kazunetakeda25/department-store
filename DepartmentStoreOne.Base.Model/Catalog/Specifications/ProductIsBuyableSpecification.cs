using System;
using Department.Base.Model.Common.Specifications;

namespace Department.Base.Model.Catalog
{
    public class ProductIsBuyableSpecification : ISpecification<Product>
    {       
        public virtual bool IsSatisfiedBy(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

           return product.IsActive && product.IsBuyable;
        }
        
    }
}
