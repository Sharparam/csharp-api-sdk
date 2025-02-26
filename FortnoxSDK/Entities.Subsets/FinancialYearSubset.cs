using System;
using Fortnox.SDK.Serialization;
using Newtonsoft.Json;

// ReSharper disable UnusedMember.Global

namespace Fortnox.SDK.Entities
{
    /// <remarks/>
    [Entity(SingularName = "FinancialYear", PluralName = "FinancialYears")]
    public class FinancialYearSubset
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
        [JsonProperty("accountCharts")]
        public string AccountChartType { get; set; }

        ///<summary> Accounting Method </summary>
        [JsonProperty]
        public AccountingMethod? AccountingMethod { get; set; }
    }
}
