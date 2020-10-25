namespace FortnoxAPILibrary
{
    public class InvoiceSearch : BaseSearch
    {
		[SearchParameter("sortby")]
		public Sort.By.Invoice? SortBy { get; set; }

		[SearchParameter("filter")]
		public Filter.Invoice? FilterBy { get; set; }


        [SearchParameter]
		public string Credit { get; set; }

        [SearchParameter]
		public string CostCenter { get; set; }

        [SearchParameter]
		public string Currency { get; set; }

        [SearchParameter]
		public string CustomerName { get; set; }

        [SearchParameter]
		public string CustomerNumber { get; set; }

        [SearchParameter]
		public string DocumentNumber { get; set; }

        [SearchParameter]
		public string ExternalInvoiceReference1 { get; set; }

        [SearchParameter]
		public string ExternalInvoiceReference2 { get; set; }

        [SearchParameter]
		public string InvoiceType { get; set; }

        [SearchParameter]
		public string NotCompleted { get; set; }

        [SearchParameter]
		public string OCR { get; set; }

        [SearchParameter]
		public string OurReference { get; set; }

        [SearchParameter]
		public string Project { get; set; }

        [SearchParameter]
		public string Sent { get; set; }

        [SearchParameter]
		public string YourOrderNumber { get; set; }

        [SearchParameter]
		public string YourReference { get; set; }
    }
}
