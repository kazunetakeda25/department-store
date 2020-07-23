using System;
using Department.Base.Model.Common;

namespace Department.Base.Model.StaticContent
{
    public partial class Blog : ContentItem
    {
        public Blog()
        {
            Permalink = ":folder";
        }

        public IMutablePagedList<BlogArticle> Articles { get; set; }

        public override string Handle => Name.Handelize();
    }
}