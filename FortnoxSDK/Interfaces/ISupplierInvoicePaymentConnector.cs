using System;
using System.Threading.Tasks;
using Fortnox.SDK.Entities;
using Fortnox.SDK.Search;

// ReSharper disable UnusedMember.Global
namespace Fortnox.SDK.Interfaces
{
    /// <remarks/>
    public interface ISupplierInvoicePaymentConnector : IEntityConnector
	{
        [Obsolete(APIConstants.ObsoleteSyncMethodWarning)]
		SupplierInvoicePayment Update(SupplierInvoicePayment supplierInvoicePayment);
        [Obsolete(APIConstants.ObsoleteSyncMethodWarning)]
		SupplierInvoicePayment Create(SupplierInvoicePayment supplierInvoicePayment);
        [Obsolete(APIConstants.ObsoleteSyncMethodWarning)]
		SupplierInvoicePayment Get(long? id);
        [Obsolete(APIConstants.ObsoleteSyncMethodWarning)]
		void Delete(long? id);
        [Obsolete(APIConstants.ObsoleteSyncMethodWarning)]
		EntityCollection<SupplierInvoicePaymentSubset> Find(SupplierInvoicePaymentSearch searchSettings);
        [Obsolete(APIConstants.ObsoleteSyncMethodWarning)]
		public void Bookkeep(long? id);

        Task<SupplierInvoicePayment> UpdateAsync(SupplierInvoicePayment supplierInvoicePayment);
		Task<SupplierInvoicePayment> CreateAsync(SupplierInvoicePayment supplierInvoicePayment);
		Task<SupplierInvoicePayment> GetAsync(long? id);
		Task DeleteAsync(long? id);
		Task<EntityCollection<SupplierInvoicePaymentSubset>> FindAsync(SupplierInvoicePaymentSearch searchSettings);
        public Task BookkeepAsync(long? id);
	}
}
