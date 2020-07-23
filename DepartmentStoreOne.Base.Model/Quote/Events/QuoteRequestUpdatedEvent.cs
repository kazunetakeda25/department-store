using Department.Base.Model.Common.Events;

namespace Department.Base.Model.Quote.Events
{
    public class QuoteRequestUpdatedEvent : DomainEvent
    {
        public QuoteRequestUpdatedEvent(QuoteRequest quoteRequest)
        {
            QuoteRequest = quoteRequest;
        }

        public QuoteRequest QuoteRequest { get; set; }
    }
}