using System;
using Fortnox.SDK.Serialization;
using Newtonsoft.Json;

namespace Fortnox.SDK.Entities
{
    [Entity(SingularName = "TermsOfPayment", PluralName = "TermsOfPayments")]
    public class TermsOfPayment
    {

        ///<summary> Direct URL to the record </summary>
        [ReadOnly]
        [JsonProperty("@url")]
        public Uri Url { get; private set; }

        ///<summary> The code of the term of payment </summary>
        [JsonProperty]
        public string Code { get; set; }

        ///<summary> The description of the term of payment </summary>
        [JsonProperty]
        public string Description { get; set; }
    }
}