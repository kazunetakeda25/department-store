using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.Base.Model.Catalog;

namespace Department.Base.Model
{
    /// <summary>
    /// Represent menu link  associated to product 
    /// </summary>
    public class ProductMenuLink : MenuLink
    {
        public Product Product { get; set; }
        public override string Type => "product";
    }
}
