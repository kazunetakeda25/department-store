using Newtonsoft.Json;

namespace Department.Base.Model.Cart
{
    public class UpdateCartCommentRequest
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }
    }
}
