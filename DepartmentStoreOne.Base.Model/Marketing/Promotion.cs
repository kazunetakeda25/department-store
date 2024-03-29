using System;
using System.Collections.Generic;
using Department.Base.Model.Common;

namespace Department.Base.Model.Marketing
{
    /// <summary>
    /// Represents promotion object
    /// </summary>
    public partial class Promotion : Entity
    {
        public IList<string> Coupons { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }
    }
}