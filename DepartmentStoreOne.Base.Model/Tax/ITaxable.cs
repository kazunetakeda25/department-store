using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.Base.Model.Common;

namespace Department.Base.Model
{
    /// <summary>
    /// It is an abstraction that represents a taxable entity
    /// </summary>
    public interface ITaxable
    {
        Currency Currency { get; }
        Money TaxTotal { get; }
        decimal TaxPercentRate { get; }
        string TaxType { get; }
        IList<TaxDetail> TaxDetails { get; }

        void ApplyTaxRates(IEnumerable<TaxRate> taxRates);
    }
}
