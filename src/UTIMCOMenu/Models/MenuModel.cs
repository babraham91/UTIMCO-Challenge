using Newtonsoft.Json;
using System.Collections.Generic;

namespace UTIMCOMenu.Models
{
    public class MenuModel
    {
        [JsonProperty("header")]
        public string header { get; set; }
        [JsonProperty("items")]
        public IEnumerable<ItemModel> items { get; set; }
    }
}
