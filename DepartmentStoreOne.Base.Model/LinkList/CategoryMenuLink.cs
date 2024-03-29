using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.Base.Model.Catalog;

namespace Department.Base.Model
{
    /// <summary>
    /// Represent menu link  associated to category 
    /// </summary>
    public class CategoryMenuLink : MenuLink
    {

        public Category Category { get; set; }
        public override string Type => "collection";
    }
}
