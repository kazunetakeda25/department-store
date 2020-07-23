using Department.Base.Model.Stores;

namespace Department.Base.Model.Common
{
    public interface IBaseUrlBuilder
    {
        string ToAppAbsolute(string virtualPath);
        string ToAppAbsolute(string virtualPath, Store store, Language language);
        string ToAppRelative(string virtualPath);
        string ToAppRelative(string virtualPath, Store store, Language language);
        string ToLocalPath(string virtualPath);
    }
}
