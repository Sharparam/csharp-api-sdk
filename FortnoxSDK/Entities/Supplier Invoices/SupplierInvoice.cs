using Fortnox.SDK.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Fortnox.SDK.Entities
{
    [Entity(SingularName = "SupplierInvoice", PluralName = "SupplierInvoices")]
    public class SupplierInvoice
    {

        ///<summary> Direct url to the record </summary>
        [ReadOnly]
        [JsonProperty("@url")]
        public Uri Url { get; private set; }

        ///<summary> Accounting Method </summary>
        [ReadOnly]
        [JsonProperty]
        public AccountingMethod? AccountingMethod { get; private set; }

        ///<summary> Administration fee </summary>
        [JsonProperty]
        public decimal? AdministrationFee { get; set; }

        ///<summary> Name of authorizer on invoice (only in list view, not single) </summary>
        [ReadOnly]
        [JsonProperty]
        public string AuthorizerName { get; private set; }

        ///<summary> Balance of invoice </summary>
        [ReadOnly]
        [JsonProperty]
        public string Balance { get; private set; }

        ///<summary> If the invoice is bookkept </summary>
        [ReadOnly]
        [JsonProperty]
        public bool? Booked { get; private set; }

        ///<summary> If the invoice is cancelled </summary>
        [ReadOnly]
        [JsonProperty]
        public bool? Cancelled { get; private set; }

        ///<summary> Comments </summary>
        [JsonProperty]
        public string Comments { get; set; }

        ///<summary> Cost Center </summary>
        [JsonProperty]
        public string CostCenter { get; set; }

        ///<summary> If invoice is a Credit invoice (to post a credit invoice, use negative delivery quantity) </summary>
        [ReadOnly]
        [JsonProperty]
        public bool? Credit { get; private set; }

        ///<summary> Reference to credit invoice, if one exists </summary>
        [ReadOnly]
        [JsonProperty]
        public long? CreditReference { get; private set; }

        ///<summary> Currency </summary>
        [JsonProperty]
        public string Currency { get; set; }

        ///<summary> Currency rate </summary>
        [JsonProperty]
        public decimal? CurrencyRate { get; set; }

        ///<summary> Currency unit </summary>
        [JsonProperty]
        public decimal? CurrencyUnit { get; set; }

        ///<summary> Disable payment file </summary>
        [JsonProperty]
        public bool? DisablePaymentFile { get; set; }

        ///<summary> Due date (You must specify this date even if you have posted terms of payment) </summary>
        [JsonProperty]
        public DateTime? DueDate { get; set; }

        ///<summary> External invoice number </summary>
        [JsonProperty]
        public string ExternalInvoiceNumber { get; set; }

        ///<summary> External invoice series </summary>
        [JsonProperty]
        public string ExternalInvoiceSeries { get; set; }

        ///<summary> Final Pay Date of the supplierinvoice </summary>
        [ReadOnly]
        [JsonProperty]
        public DateTime? FinalPayDate { get; private set; }

        ///<summary> Freight </summary>
        [JsonProperty]
        public decimal? Freight { get; set; }

        ///<summary> Given Number </summary>
        [JsonProperty]
        public long? GivenNumber { get; set; }

        ///<summary> Invoice date </summary>
        [JsonProperty]
        public DateTime? InvoiceDate { get; set; }

        ///<summary> Invoice Number </summary>
        [JsonProperty]
        public string InvoiceNumber { get; set; }

        ///<summary> OCR number </summary>
        [JsonProperty]
        public string OCR { get; set; }

        ///<summary> Reference to offer number </summary>
        [JsonProperty]
        public string OurReference { get; set; }

        ///<summary> If invoice is under payment or not </summary>
        [JsonProperty]
        public bool? PaymentPending { get; set; }

        ///<summary> Project code </summary>
        [JsonProperty]
        public string Project { get; set; }

        ///<summary> Round of amount </summary>
        [JsonProperty]
        public decimal? RoundOffValue { get; set; }

        ///<summary> Sales type </summary>
        [JsonProperty]
        public SalesType? SalesType { get; set; }

        ///<summary> – </summary>
        [JsonProperty]
        public IList<SupplierInvoiceRow> SupplierInvoiceRows { get; set; }

        ///<summary> Supplier number </summary>
        [JsonProperty]
        public string SupplierNumber { get; set; }

        ///<summary> Supplier name </summary>
        [ReadOnly]
        [JsonProperty]
        public string SupplierName { get; private set; }

        ///<summary> Total amount </summary>
        [JsonProperty]
        public decimal? Total { get; set; }

        ///<summary> Vat amount </summary>
        [JsonProperty]
        public decimal? VAT { get; set; }

        ///<summary> Vat type </summary>
        [JsonProperty]
        public SupplierInvoiceVATType? VATType { get; set; }

        ///<summary> Customer reference </summary>
        [JsonProperty]
        public string YourReference { get; set; }

        [ReadOnly]
        [JsonProperty]
        public IList<VoucherReference> Vouchers { get; private set; }

        ///<summary> Voucher number for the invoice. This is created when the invoice is bookkept.</summary>
        [Obsolete("Seems like this is only populated in bookkeep action response. Use Vouchers property instead for other use cases")]
        [ReadOnly]
        [JsonProperty]
        public long? VoucherNumber { get; private set; }

        ///<summary> Voucher series for the invoice. This is created when the invoice is bookkept.</summary>
        [Obsolete("Seems like this is only populated in bookkeep action response. Use Vouchers property instead for other use cases")]
        [ReadOnly]
        [JsonProperty]
        public string VoucherSeries { get; private set; }

        ///<summary> Voucher year for the invoice. This is created when the invoice is bookkept.</summary>
        [Obsolete("Seems like this is only populated in bookkeep action response. Use Vouchers property instead for other use cases")]
        [ReadOnly]
        [JsonProperty]
        public long? VoucherYear { get; private set; }
    }
}