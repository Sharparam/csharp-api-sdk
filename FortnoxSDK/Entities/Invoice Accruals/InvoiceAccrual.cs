using Fortnox.SDK.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Fortnox.SDK.Entities
{
    [Entity(SingularName = "InvoiceAccrual", PluralName = "InvoiceAccruals")]
    public class InvoiceAccrual
    {

        ///<summary> Direct URL to the record </summary>
        [ReadOnly]
        [JsonProperty("@url")]
        public Uri Url { get; private set; }

        ///<summary> Account for the accrual </summary>
        [JsonProperty]
        public long? AccrualAccount { get; set; }

        ///<summary> Description of the accrual </summary>
        [JsonProperty]
        public string Description { get; set; }

        ///<summary> End date </summary>
        [JsonProperty]
        public DateTime? EndDate { get; set; }

        ///<summary> – </summary>
        [JsonProperty]
        public IList<InvoiceAccrualRow> InvoiceAccrualRows { get; set; }

        ///<summary> Invoice number </summary>
        [JsonProperty]
        public long? InvoiceNumber { get; set; }

        ///<summary> Type of period </summary>
        [JsonProperty]
        public string Period { get; set; }

        ///<summary> Account for the revenue </summary>
        [JsonProperty]
        public long? RevenueAccount { get; set; }

        ///<summary> Start date </summary>
        [JsonProperty]
        public DateTime? StartDate { get; set; }

        ///<summary> Total times of accruals </summary>
        [ReadOnly]
        [JsonProperty]
        public long? Times { get; private set; }

        ///<summary> Total of the accrual </summary>
        [JsonProperty]
        public decimal? Total { get; set; }

        ///<summary> Is VAT included </summary>
        [JsonProperty]
        public bool? VATIncluded { get; set; }
    }
}