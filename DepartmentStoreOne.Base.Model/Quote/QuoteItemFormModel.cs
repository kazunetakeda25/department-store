using System.Collections.Generic;

namespace Department.Base.Model.Quote
{
    public partial class QuoteItemFormModel
    {
        public QuoteItemFormModel()
        {
            ProposalPrices = new List<TierPriceFormModel>();
        }

        public string Id { get; set; }

        public string Comment { get; set; }

        public TierPriceFormModel SelectedTierPrice { get; set; }

        public IList<TierPriceFormModel> ProposalPrices { get; set; }
    }
}