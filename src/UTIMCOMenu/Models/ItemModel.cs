using Newtonsoft.Json;

namespace UTIMCOMenu.Models
{
    public class ItemModel
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("label")]
        public string label { get; set; }
    }
}
