using System;
using System.Collections.Generic;
using System.Text;

namespace Department.Base.Model.StaticContent
{
    public interface IStaticContentItemFactory
    {
        ContentItem GetItemFromPath(string path);
    }
}
