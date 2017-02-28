using Newtonsoft.Json;

namespace UTIMCOMenu.Models
{
    public class MenuJson
    {
        [JsonProperty("menu")]
        public MenuModel menu { get; set; }
    }
}
