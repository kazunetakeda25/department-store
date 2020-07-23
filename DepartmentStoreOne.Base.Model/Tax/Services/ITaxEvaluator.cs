using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Base.Model.Tax.Services
{
    public interface ITaxEvaluator
    {
        Task EvaluateTaxesAsync(TaxEvaluationContext context, IEnumerable<ITaxable> owners);
    }
}
