using Fortnox.SDK.Serialization;
using Newtonsoft.Json;
using System;

namespace Fortnox.SDK.Entities
{
    [Entity(SingularName = "FinancialYear", PluralName = "FinancialYears")]
    public class FinancialYear
    {

        ///<summary> Direct URL to the record </summary>
        [ReadOnly]
        [JsonProperty("@url")]
        public Uri Url { get; private set; }

        ///<summary> The ID of the financial year </summary>
        [ReadOnly]
        [JsonProperty]
        public long? Id { get; private set; }

        ///<summary> Start date of the financial year </summary>
        [JsonProperty]
        public DateTime? FromDate { get; set; }

        ///<summary> End date of the financial year </summary>
        [JsonProperty]
        public DateTime? ToDate { get; set; }

        ///<summary> Type of the account chart </summary>
        [JsonProperty]
        public string AccountChartType { get; set; }

        ///<summary> Accounting Method </summary>
        [JsonProperty]
        public AccountingMethod? AccountingMethod { get; set; }
    }
}