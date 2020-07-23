namespace DepartmentStoreOne.Base.Model
{
    public partial class BaseNotification
    {
        public string Title { get; set; }

        public string Message { get; set; }

        public BaseNotificationType Type { get; set; }
    }
}