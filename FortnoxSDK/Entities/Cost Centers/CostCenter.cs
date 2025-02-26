using System;
using Fortnox.SDK.Serialization;
using Newtonsoft.Json;

namespace Fortnox.SDK.Entities
{
    [Entity(SingularName = "CostCenter", PluralName = "CostCenters")]
    public class CostCenter
    {

        ///<summary> Direct URL to the record </summary>
        [ReadOnly]
        [JsonProperty("@url")]
        public Uri Url { get; private set; }

        ///<summary> The code of the cost center </summary>
        [JsonProperty]
        public string Code { get; set; }

        ///<summary> The description of the cost center </summary>
        [JsonProperty]
        public string Description { get; set; }

        ///<summary> The note of the cost center </summary>
        [JsonProperty]
        public string Note { get; set; }

        ///<summary> If the cost center is active or not </summary>
        [JsonProperty]
        public bool? Active { get; set; }
    }
}