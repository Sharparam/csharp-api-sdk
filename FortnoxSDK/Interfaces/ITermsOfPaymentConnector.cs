using System;
using System.Threading.Tasks;
using Fortnox.SDK.Entities;
using Fortnox.SDK.Search;

// ReSharper disable UnusedMember.Global
namespace Fortnox.SDK.Interfaces
{
    /// <remarks/>
    public interface ITermsOfPaymentConnector : IEntityConnector
	{
        [Obsolete(APIConstants.ObsoleteSyncMethodWarning)]
		TermsOfPayment Update(TermsOfPayment termsOfPayment);
        [Obsolete(APIConstants.ObsoleteSyncMethodWarning)]
		TermsOfPayment Create(TermsOfPayment termsOfPayment);
        [Obsolete(APIConstants.ObsoleteSyncMethodWarning)]
		TermsOfPayment Get(string id);
        [Obsolete(APIConstants.ObsoleteSyncMethodWarning)]
		void Delete(string id);
        [Obsolete(APIConstants.ObsoleteSyncMethodWarning)]
		EntityCollection<TermsOfPayment> Find(TermsOfPaymentSearch searchSettings);

		Task<TermsOfPayment> UpdateAsync(TermsOfPayment termsOfPayment);
		Task<TermsOfPayment> CreateAsync(TermsOfPayment termsOfPayment);
		Task<TermsOfPayment> GetAsync(string id);
		Task DeleteAsync(string id);
		Task<EntityCollection<TermsOfPayment>> FindAsync(TermsOfPaymentSearch searchSettings);
	}
}
