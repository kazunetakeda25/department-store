using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PagedList.Core;

namespace Department.Base.Model.Quote.Services
{
    public interface IQuoteService
    {
        Task<IPagedList<QuoteRequest>> SearchQuotesAsync(QuoteSearchCriteria criteria);
        IPagedList<QuoteRequest> SearchQuotes(QuoteSearchCriteria criteria);
    }
}
